//-----------------------------------------------------------------------
// <copyright file="IRepository`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Data.Repository
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public interface IRepository<TEntity> where TEntity : class
	{
		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

		IEnumerable<TEntity> GetAll();

		TEntity Get(int id);

		TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

		void Add(TEntity entity);

		void AddRange(IEnumerable<TEntity> entities);

		void Remove(TEntity entity);

		void RemoveRange(IEnumerable<TEntity> entities);
	}
}
