//-----------------------------------------------------------------------
// <copyright file= "IngosMediatorExtension.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 20:31:34
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Domain.SeedWorks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingos.Infrastructure
{
    public static class IngosMediatorExtension
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task DispatchDomainEventsAsync(this IMediator mediator, IngosApplicationDbContext context)
        {
            var domainEntities = context.ChangeTracker
                .Entries<EntityBase>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());

            foreach (var domainEvent in domainEvents)
                await mediator.Publish(domainEvent);
        }
    }
}