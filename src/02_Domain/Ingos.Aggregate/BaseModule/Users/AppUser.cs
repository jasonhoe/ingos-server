//-----------------------------------------------------------------------
// <copyright file= "AppUser.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:36:25
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Aggregate.SeedWork;
using Ingos.Aggregate.SeedWork.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Aggregate.BaseModule.Users
{
    public class AppUser : EntityBase, IAggregateRoot
    {
        #region Attributes

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        #endregion Attributes
    }
}