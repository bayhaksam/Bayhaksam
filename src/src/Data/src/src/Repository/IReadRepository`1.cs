﻿//-----------------------------------------------------------------------
// <copyright file="IReadRepository`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Data.Repository
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public interface IReadRepository<TEntity> where TEntity : class
	{
		bool IsExists(int id);

		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

		IEnumerable<TEntity> GetAll();

		TEntity Get(int id);

		TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
	}
}
