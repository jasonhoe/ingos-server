//-----------------------------------------------------------------------
// <copyright file= "IProductRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 18:50:25
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Domain.AggregateModels.ProductAggregates;
using Ingos.Infrastructure.Core.EntityFrameworkCore.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Infrastructure.Repositories.Products.Contacts
{
    public interface IProductRepository : IRepository<Product, long>
    {
    }
}