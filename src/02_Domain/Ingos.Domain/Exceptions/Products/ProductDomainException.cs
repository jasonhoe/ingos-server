//-----------------------------------------------------------------------
// <copyright file= "ProductDomainException.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 18:52:11
// Modified by:
// Description: Ingos Product domain's custom exception type
//-----------------------------------------------------------------------
using System;

namespace Ingos.Domain.Exceptions.Products
{
    public class ProductDomainException : Exception
    {
        #region Ctos

        public ProductDomainException()
        {
        }

        public ProductDomainException(string message)
            : base(message)
        {
        }

        public ProductDomainException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        #endregion Ctos
    }
}