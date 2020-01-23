﻿//-----------------------------------------------------------------------
// <copyright file= "IngosSwaggerDescriptionOptions.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/23 12:51:28
// Modified by:
// Description: Ingos swagger custom config options
//-----------------------------------------------------------------------
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

namespace Ingos.Api.Core.Swagger
{
    public class IngosSwaggerDescriptionOptions
    {
        #region Attributes

        /// <summary>
        /// Author's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Author's email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Author's site address
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// This api's description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The title of this application
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The api's open source license
        /// </summary>
        public OpenApiLicense License { get; set; }

        /// <summary>
        /// The collection of api description xml files
        /// </summary>
        public IEnumerable<string> Paths { get; set; }

        #endregion Attributes
    }
}