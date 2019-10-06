//-----------------------------------------------------------------------
// <copyright file= "AppUserContext.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:55:27
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Aggregate.BaseModule.Users;
using Ingos.Aggregate.SeedWork;
using Ingos.Aggregate.SeedWork.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ingos.Domain.BaseModule.Users.Repositories
{
    public class AppUserContext : DbContext, IUnitOfWork
    {
        #region Tables

        /// <summary>
        /// The mysql server schema name
        /// </summary>
        public const string Schema = "base";

        /// <summary>
        /// User
        /// </summary>
        public DbSet<AppUser> AppUsers { get; set; }

        #endregion Tables

        public AppUserContext(DbContextOptions<AppUserContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}