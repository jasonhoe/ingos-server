//-----------------------------------------------------------------------
// <copyright file= "BaseModuleProfiles.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/3 20:56:59
// Modified by:
// Description: Base module's automapper mapping configuration file
//-----------------------------------------------------------------------
using AutoMapper;
using Ingos.Aggregate.BaseModule;
using Ingos.Dto.BaseModule.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Application.BaseModule
{
    /// <summary>
    /// Base module's automapper mapping rules
    /// </summary>
    public class BaseModuleProfiles : Profile
    {
        /// <summary>
        /// The autoMapper mapping configuration rules
        /// </summary>
        public BaseModuleProfiles()
        {
            // user mapping rules
            //
            CreateMap<AppUserEditDto, AppUser>();
        }
    }
}