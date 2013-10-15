﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InterLinq
{
    /// <summary>
    /// Interface providing methods to get <see cref="IQueryable{T}"/>.
    /// </summary>
    public interface IQueryHandler
    {
        /// <summary>
        /// Returns an <see cref="IQueryable{T}"/>.
        /// </summary>
        /// <param name="type">Type of the returned <see cref="IQueryable{T}"/>.</param>
        /// <returns>Returns an <see cref="IQueryable{T}"/>.</returns>
        //IQueryable Get(Type type);

        /// <summary>
        /// Returns an <see cref="IQueryable{T}"/>.
        /// </summary>
        /// <typeparam name="T">Generic Argument of the returned <see cref="IQueryable{T}"/>.</typeparam>
        /// <returns>Returns an <see cref="IQueryable{T}"/>.</returns>
        //IQueryable<T> Get<T>() where T : class;

        /// <summary>
        /// Returns an <see cref="IQueryable{T}"/>.
        /// </summary>
        /// <param name="type">Type of the returned <see cref="IQueryable{T}"/>.</param>
        /// <param name="queryName">The named query to call.</param>
        /// <param name="parameters">The parameters of the named query.</param>
        /// <returns>Returns an <see cref="IQueryable{T}"/>.</returns>
        IQueryable Get(Type type, string queryName, object sessionObject, params object[] parameters);

        /// <summary>
        /// Returns an <see cref="IQueryable{T}"/>.
        /// </summary>
        /// <typeparam name="T">Generic Argument of the returned <see cref="IQueryable{T}"/>.</typeparam>
        /// <param name="queryName">The named query to call.</param>
        /// <param name="parameters">The parameters of the named query.</param>
        /// <returns>Returns an <see cref="IQueryable{T}"/>.</returns>
        IQueryable<T> Get<T>(string queryName, object sessionObject, params object[] parameters) where T : class;

        /// <summary>
        /// Tells the <see cref="IQueryHandler"/> to start a new the session.
        /// </summary>
        /// <returns>True, if the session creation was successful. False, if not.</returns>
        object StartSession();

        /// <summary>
        /// Tells the <see cref="IQueryHandler"/> to close the current session.
        /// </summary>
        /// <returns>True, if the session closing was successful. False, if not.</returns>
        bool CloseSession(object sessionObject);
    }
}
