//-----------------------------------------------------------------------
// <copyright file= "DateTimeToStringConverter.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/6 19:57:33
// Modified by:
// Description: Convert datetime to string with yyyy-MM-dd HH:mm:ss format
//-----------------------------------------------------------------------
using AutoMapper;
using System;

namespace Ingos.Infrastructure.AutoMapper.Converters
{
    /// <summary>
    /// Convert datetime to string with yyyy-MM-dd HH:mm:ss format
    /// </summary>
    public class DateTimeToStringConverter : IValueConverter<DateTime, string>
    {
        public string Convert(DateTime source, ResolutionContext context)
            => source.ToString("yyyy-MM-dd HH:mm:ss");
    }
}