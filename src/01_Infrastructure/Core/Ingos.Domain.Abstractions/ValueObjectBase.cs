//-----------------------------------------------------------------------
// <copyright file= "ValueObjectBase.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 20:19:23
// Modified by:
// Description: Generic base value object class
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Domain.Abstractions
{
    public abstract class ValueObjectBase<T> where T : ValueObjectBase<T>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}