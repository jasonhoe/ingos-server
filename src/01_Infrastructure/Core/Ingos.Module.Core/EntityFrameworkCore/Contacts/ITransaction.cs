﻿//-----------------------------------------------------------------------
// <copyright file= "ITransaction.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/2/25 21:40:35
// Modified by:
// Description: Database transaction interface
//-----------------------------------------------------------------------
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace Ingos.Infrastructure.Core.EntityFrameworkCore.Contacts
{
    public interface ITransaction
    {
        /// <summary>
        /// Get current transaction instance
        /// </summary>
        IDbContextTransaction GetCurrentTransaction();

        /// <summary>
        /// Check current whether contain active transactions
        /// </summary>
        bool HasActiveTransaction { get; }

        /// <summary>
        /// Begin transaction
        /// </summary>
        /// <returns></returns>
        Task<IDbContextTransaction> BeginTransactionAsync();

        /// <summary>
        /// Commit transaction
        /// </summary>
        /// <param name="transaction">The instance of database transaction</param>
        /// <returns></returns>
        Task CommitTransactionAsync(IDbContextTransaction transaction);

        /// <summary>
        /// Rollback transaction
        /// </summary>
        void RollbackTransaction();
    }
}