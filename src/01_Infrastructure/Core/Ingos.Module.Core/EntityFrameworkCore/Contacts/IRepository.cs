//-----------------------------------------------------------------------
// <copyright file= "IRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/2/25 19:53:03
// Modified by:
// Description: Generic base repository interface
//-----------------------------------------------------------------------
using Ingos.Domain.Abstractions;
using Ingos.Domain.Abstractions.Contacts;
using System.Threading;
using System.Threading.Tasks;

namespace Ingos.Infrastructure.Core.EntityFrameworkCore.Contacts
{
    /// <summary>
    /// Repository base interface
    /// </summary>
    /// <typeparam name="TEntity">The aggreate root entity</typeparam>
    /// <typeparam name="TPrimaryKey">The primary key of this aggreate root</typeparam>
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : EntityBase<TPrimaryKey>, IAggregateRoot
    {
        /// <summary>
        /// The instance of unit of work
        /// </summary>
        IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Insert aggreate root entity
        /// </summary>
        /// <param name="entity">The aggreate root entity</param>
        /// <returns></returns>
        TEntity Insert(TEntity entity);

        /// <summary>
        /// Insert aggreate root entity
        /// </summary>
        /// <param name="entity">The aggreate root entity</param>
        /// <param name="cancellationToken">Async task cancel token</param>
        /// <returns></returns>
        Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update aggreate root entity
        /// </summary>
        /// <param name="entity">The aggreate root entity</param>
        /// <returns></returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Update aggreate root entity
        /// </summary>
        /// <param name="entity">The aggreate root entity</param>
        /// <param name="cancellationToken">Async task cancel token</param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove aggreate root entity
        /// </summary>
        /// <param name="entity">The aggreate root entity</param>
        /// <returns></returns>
        TEntity Remove(TEntity entity);

        /// <summary>
        /// Remove aggreate root entity
        /// </summary>
        /// <param name="entity">The aggreate root entity</param>
        /// <param name="cancellationToken">Async task cancel token</param>
        /// <returns></returns>
        Task<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete aggreate root entity by primary key
        /// </summary>
        /// <param name="id">The primary key of this aggreate root entity</param>
        /// <returns></returns>
        bool Delete(TPrimaryKey id);

        /// <summary>
        /// Delete aggreate root entity by primary key
        /// </summary>
        /// <param name="id">The primary key of this aggreate root entity</param>
        /// <param name="cancellationToken">Async task cancel token</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(TPrimaryKey id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get aggreate root entity by primary key
        /// </summary>
        /// <param name="id">The primary key of this aggreate root entity</param>
        /// <returns></returns>
        TEntity GetEntityById(TPrimaryKey id);

        /// <summary>
        /// Get aggreate root entity by primary key
        /// </summary>
        /// <param name="id">The primary key of this aggreate root entity</param>
        /// <param name="cancellationToken">Async task cancel token</param>
        /// <returns></returns>
        Task<TEntity> GetEntityByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default);
    }
}