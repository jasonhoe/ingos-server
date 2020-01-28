//-----------------------------------------------------------------------
// <copyright file= "IUnitOfWork.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 20:27:20
// Modified by:
// Description:
//-----------------------------------------------------------------------
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ingos.Domain.SeedWorks.Contacts
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        ///
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);
    }
}