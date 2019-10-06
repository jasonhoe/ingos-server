//-----------------------------------------------------------------------
// <copyright file= "ValueObjectBase.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/27 16:46:04
// Modified by:
// Description: Generic base value object class
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Aggregate.SeedWork
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