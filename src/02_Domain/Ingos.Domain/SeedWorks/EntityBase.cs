﻿//-----------------------------------------------------------------------
// <copyright file= "EntityBase.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2020/1/28 20:12:06
// Modified by:
// Description: Generic base domain object class
//-----------------------------------------------------------------------
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Domain.SeedWorks
{
    /// <summary>
    /// Abstract domain object base class
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public abstract class EntityBase<TPrimaryKey>
    {
        #region Domain Attributes

        /// <summary>
        /// Primary key
        /// </summary>
        public TPrimaryKey Id { get; protected set; }

        #endregion Domain Attributes

        #region Domain Events

        /// <summary>
        ///
        /// </summary>
        private List<INotification> _domainEvents;

        /// <summary>
        /// Domain events collection
        /// </summary>
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();

        /// <summary>
        /// Add domain event
        /// </summary>
        /// <param name="notification"></param>
        public void AddDomainEvent(INotification notification)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(notification);
        }

        /// <summary>
        /// Clear all domain event
        /// </summary>
        public void ClearDomainEvents() => _domainEvents?.Clear();

        /// <summary>
        /// Remove domain event
        /// </summary>
        /// <param name="notification"></param>
        public void RemoveDomainEvents(INotification notification) => _domainEvents?.Remove(notification);

        #endregion Domain Events

        #region Domain methods

        /// <summary>
        /// Determine the two classes are not equal
        /// </summary>
        /// <param name="a">class a</param>
        /// <param name="b">class b</param>
        /// <returns></returns>
        public static bool operator !=(EntityBase<TPrimaryKey> a, EntityBase<TPrimaryKey> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Determine the two classes are equal
        /// </summary>
        /// <param name="a">class a</param>
        /// <param name="b">class b</param>
        /// <returns></returns>
        public static bool operator ==(EntityBase<TPrimaryKey> a, EntityBase<TPrimaryKey> b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object
        /// </summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // Check whether the obj is null
            if (!(obj is EntityBase<TPrimaryKey> compareTo))
                return false;

            // Check whether the two obj is the same
            if (ReferenceEquals(this, compareTo))
                return true;

            // Check whether the primary key is the same
            return Id.Equals(compareTo.Id);
        }

        /// <summary>
        /// Get the obj's hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<TPrimaryKey>.Default.GetHashCode(Id);
        }

        /// <summary>
        /// Rewrite the tostring method to return the obj info
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }

        #endregion Domain methods
    }

    /// <summary>
    /// Guid 类型主键实体基类
    /// </summary>
    public abstract class EntityBase : EntityBase<Guid>
    { }
}