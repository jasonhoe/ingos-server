//-----------------------------------------------------------------------
// <copyright file= "Product.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/2/26 19:47:39
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Domain.Abstractions;
using Ingos.Domain.Abstractions.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Domain.AggregateModels.ProductAggregates
{
    public class Product : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// ctor
        /// </summary>
        protected Product()
        { }

        /// <summary>
        ///
        /// </summary>
        public string ProductName { get; private set; }
    }
}