using Ingos.Api.Core.Extensions.ApiVersion;
using Ingos.Api.Core.Extensions.Swagger;
using Ingos.Domain.BaseModule.Users.Repositories;
using Ingos.Infrastructure.AutoMapper.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ingos.Api
{
    public class Startup
    {
        // Default Cors policy name
        private const string _defaultCorsPolicyName = "Ingos.Api.Cors";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(
                // Add cors authorization filter
                options => options.Filters.Add(new CorsAuthorizationFilterFactory(_defaultCorsPolicyName))
            ).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Config automapper mapping rules
            services.AddAutoMapperProfiles();

            // Config mysql server database connection
            services.AddDbContext<AppUserContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("IngosApplication")));

            // Use lowercase urls router mode
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
            });

            // Config api version
            services.AddApiVersion();

            // Config cors policy
            services.AddCors(options => options.AddPolicy(_defaultCorsPolicyName,
                builder => builder.WithOrigins(
                        Configuration["Application:CorsOrigins"]
                        .Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray()
                    )
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()));

            // Add swagger api doc support
            services.AddSwagger(new SwaggerDescriptionOptions
            {
                Name = "Danvic Wang",
                Email = "danvic96@hotmail.com",
                Url = "https://yuiter.com",
                Description = "Ingos.API 接口文档",
                Title = "Ingos.API",
                Paths = new List<string> { "Ingos.Api.xml", "Ingos.Dto.xml" }
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // Allow cross domain request
            app.UseCors(_defaultCorsPolicyName);

            app.UseMvc();

            // Enable swagger doc
            app.UseSwagger();

            app.UseSwaggerUI(s =>
            {
                // Default load the latest version
                foreach (var description in provider.ApiVersionDescriptions.Reverse())
                {
                    s.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                        $"Sample API {description.GroupName.ToUpperInvariant()}");
                }
            });
        }
    }
}