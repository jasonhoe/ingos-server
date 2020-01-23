﻿//-----------------------------------------------------------------------
// <copyright file= "DateToStringConverter.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/6 19:59:18
// Modified by:
// Description: Convert date to string with yyyy-MM-dd format
//-----------------------------------------------------------------------
using AutoMapper;
using System;

namespace Ingos.Infrastructure.AutoMapper.Converters
{
    /// <summary>
    /// Convert date to string with yyyy-MM-dd format
    /// </summary>
    public class DateToStringConverter : IValueConverter<DateTime, string>
    {
        public string Convert(DateTime source, ResolutionContext context)
            => source.ToString("yyyy-MM-dd");
    }
}