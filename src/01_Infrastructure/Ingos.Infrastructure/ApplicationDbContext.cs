//-----------------------------------------------------------------------
// <copyright file= "ApplicationDbContext.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 19:54:06
// Modified by:
// Description: Application database context object
//-----------------------------------------------------------------------
using Ingos.Infrastructure.Core.EntityFrameworkCore;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Ingos.Infrastructure
{
    public class ApplicationDbContext : IngosBaseContext
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="options"></param>
        /// <param name="mediator"></param>
        public ApplicationDbContext(DbContextOptions options, IMediator mediator)
            : base(options, mediator)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}