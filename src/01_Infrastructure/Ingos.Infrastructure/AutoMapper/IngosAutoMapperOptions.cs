//-----------------------------------------------------------------------
// <copyright file= "IngosAutoMapperOptions.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/23 16:29:20
// Modified by:
// Description: Ingos custom config options
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace Ingos.Infrastructure.AutoMapper
{
    public class IngosAutoMapperOptions
    {
        #region Attributes

        /// <summary>
        /// The assemblies which contains mapper rules
        /// </summary>
        public IEnumerable<string> Assemblies { get; set; }

        #endregion Attributes
    }
}