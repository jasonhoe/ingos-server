//-----------------------------------------------------------------------
// <copyright file= "IngosApiVersionExtension.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/23 11:00:19
// Modified by:
// Description: Ingos custom api version dependency injection method
//-----------------------------------------------------------------------
using Microsoft.Extensions.DependencyInjection;

namespace Ingos.Api.Core.ApiVersion.Extensions
{
    public static class IngosApiVersionExtension
    {
        /// <summary>
        /// Inject api version into IServiceCollection
        /// </summary>
        /// <param name="services">The services that need to be injected into the container <see cref="IServiceCollection"/></param>
        public static IServiceCollection AddIngosApiVersion(this IServiceCollection services)
        {
            // Add api version support
            services.AddApiVersioning(o =>
            {
                // return api version info in response header
                o.ReportApiVersions = true;

                // default api version
                o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);

                // when not specifying an api version, select the default version
                o.AssumeDefaultVersionWhenUnspecified = true;
            });

            // Config api version info
            services.AddVersionedApiExplorer(option =>
            {
                // Set api version group name format
                option.GroupNameFormat = "'v'VVV";

                // when not specifying an api version, select the default version
                option.AssumeDefaultVersionWhenUnspecified = true;
            });

            return services;
        }
    }
}