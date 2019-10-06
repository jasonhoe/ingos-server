//-----------------------------------------------------------------------
// <copyright file= "IUserRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:39:18
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Aggregate.SeedWork;
using Ingos.Aggregate.SeedWork.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ingos.Aggregate.BaseModule.Users
{
    public interface IUserRepository : IRepository<AppUser>
    {
        #region Services

        /// <summary>
        /// Get user info by email address
        /// </summary>
        /// <param name="email">User email address</param>
        /// <returns></returns>
        Task<AppUser> GetAppUserByEmailAsync(string email);

        #endregion Services
    }
}