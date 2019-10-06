//-----------------------------------------------------------------------
// <copyright file= "UserDomainException.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/4 16:09:23
// Modified by:
// Description: User domain exception class
//-----------------------------------------------------------------------
using System;

namespace Ingos.Domain.BaseModule.Users.Exceptions
{
    public class UserDomainException : Exception
    {
        /// <summary>
        /// ctor
        /// </summary>
        public UserDomainException()
        { }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="message">Error message</param>
        public UserDomainException(string message)
            : base(message)
        { }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="exception">Exception info</param>
        public UserDomainException(string message, Exception exception)
            : base(message, exception)
        { }
    }
}