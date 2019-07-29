//-----------------------------------------------------------------------
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

	public interface IReadRepository<TEntity, TPrimaryKey> where TEntity : class
	{
		bool IsExists(TPrimaryKey id);

		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

		IEnumerable<TEntity> GetAll();

		TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

		TEntity Get(TPrimaryKey id);
	}
}
