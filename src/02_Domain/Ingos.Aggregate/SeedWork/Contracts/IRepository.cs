//-----------------------------------------------------------------------
// <copyright file= "IRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:32:30
// Modified by:
// Description:
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Aggregate.SeedWork.Contracts
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}