using Ingos.Api.Core.ApiVersion.Extensions;
using Ingos.Api.Core.Swagger;
using Ingos.Api.Core.Swagger.Extensions;
using Ingos.Infrastructure.AutoMapper;
using Ingos.Infrastructure.AutoMapper.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
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
            services.AddControllers();

            // Config automapper mapping rules
            //services.AddIngosAutoMapperProfiles(options =>
            //{
            //});

            // Config mysql server database connection
            //services.AddDbContext<AppUserContext>(options =>
            //    options.UseMySql(Configuration.GetConnectionString("IngosApplication")));

            // Use lowercase urls router mode
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
            });

            // Config api version
            services.AddIngosApiVersion();

            // Config cors policy
            services.AddCors(options => options.AddPolicy(_defaultCorsPolicyName,
                builder => builder.WithOrigins(
                        Configuration["Application:CorsOrigins"]
                        .Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray()
                    )
                .AllowAnyHeader()
                .AllowAnyMethod()));

            // Add swagger api doc support
            services.AddIngosSwagger(options =>
            {
                options.Name = "Danvic Wang";
                options.Email = "danvic96@hotmail.com";
                options.Url = new Uri("https://yuiter.com");
                options.Description = "Ingos.API 接口文档";
                options.Title = "Ingos.API";
                options.License = new OpenApiLicense
                {
                    Name = "MIT",
                    Url = new Uri("https://opensource.org/licenses/MIT")
                };
                options.Paths = new List<string> { "Ingos.Api.xml" };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
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

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable swagger doc
            app.UseSwagger();

            app.UseSwaggerUI(s =>
            {
                // Default load the latest version
                foreach (var description in provider.ApiVersionDescriptions.Reverse())
                {
                    s.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                        $"Ingos API {description.GroupName.ToUpperInvariant()}");
                }
            });
        }
    }
}