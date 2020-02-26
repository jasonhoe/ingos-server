//-----------------------------------------------------------------------
// <copyright file= "ProductCreatedDomainEvent.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/2/26 20:00:45
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Domain.AggregateModels.ProductAggregates;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Domain.Events.Products
{
    public class ProductCreatedDomainEvent : INotification
    {
        public Product Product { get; private set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="product"></param>
        public ProductCreatedDomainEvent(Product product)
        {
            Product = product;
        }
    }
}