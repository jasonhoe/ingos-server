//-----------------------------------------------------------------------
// <copyright file= "UserRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:49:02
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Aggregate.BaseModule.Users;
using Ingos.Aggregate.SeedWork;
using Ingos.Aggregate.SeedWork.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingos.Domain.BaseModule.Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region Initialize

        /// <summary>
        /// Db context
        /// </summary>
        private readonly AppUserContext _appUserContext;

        /// <summary>
        ///
        /// </summary>
        public IUnitOfWork UnitOfWork => _appUserContext;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="appUserContext"></param>
        public UserRepository(AppUserContext appUserContext)
        {
            _appUserContext = appUserContext ?? throw new ArgumentNullException(nameof(appUserContext));
        }

        #endregion Initialize

        #region Services

        /// <summary>
        /// Get user info by email address
        /// </summary>
        /// <param name="email">User email address</param>
        /// <returns></returns>
        public async Task<AppUser> GetAppUserByEmailAsync(string email)
        {
            return await _appUserContext.AppUsers.AsQueryable().Where(i => i.Email.Equals(email)).FirstOrDefaultAsync();
        }

        #endregion Services
    }
}