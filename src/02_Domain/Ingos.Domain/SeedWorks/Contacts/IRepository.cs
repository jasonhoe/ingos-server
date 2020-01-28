//-----------------------------------------------------------------------
// <copyright file= "IRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 20:26:53
// Modified by:
// Description:
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Domain.SeedWorks.Contacts
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}