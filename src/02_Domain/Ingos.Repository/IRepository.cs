//-----------------------------------------------------------------------
// <copyright file= "IRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/8/10 11:04:49
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Repository
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}