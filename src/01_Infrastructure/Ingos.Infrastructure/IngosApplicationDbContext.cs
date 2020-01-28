//-----------------------------------------------------------------------
// <copyright file= "IngosApplicationDbContext.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 19:54:06
// Modified by:
// Description: Ingos's application database context object
//-----------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Infrastructure
{
    public class IngosApplicationDbContext : DbContext
    {
        public IngosApplicationDbContext(DbContextOptions<IngosApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}