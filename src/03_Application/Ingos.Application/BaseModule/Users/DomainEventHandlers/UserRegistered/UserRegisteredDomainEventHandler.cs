//-----------------------------------------------------------------------
// <copyright file= "UserRegisteredDomainEventHandler.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:20:15
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Domain.BaseModule.Users.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ingos.Application.BaseModule.Users.DomainEventHandlers.UserRegistered
{
    public class UserRegisteredDomainEventHandler : INotificationHandler<UserRegisteredDomainEvent>
    {
        public Task Handle(UserRegisteredDomainEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}