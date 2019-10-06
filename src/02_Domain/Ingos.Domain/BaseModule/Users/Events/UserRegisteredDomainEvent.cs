//-----------------------------------------------------------------------
// <copyright file= "UserRegisteredDomainEvent.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:16:48
// Modified by:
// Description: Register user domain event
//-----------------------------------------------------------------------
using Ingos.Aggregate.BaseModule.Users;
using MediatR;

namespace Ingos.Domain.BaseModule.Users.Events
{
    /// <summary>
    /// User register domain event
    /// </summary>
    public class UserRegisteredDomainEvent : INotification
    {
        /// <summary>
        /// User domain object
        /// </summary>
        public AppUser AppUser { get; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="appUser">User domain object</param>
        public UserRegisteredDomainEvent(AppUser appUser)
        {
            AppUser = appUser;
        }
    }
}