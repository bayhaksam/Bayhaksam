//-----------------------------------------------------------------------
// <copyright file="EFCoreReadRepository`1.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Data.EFCore.Repository
{
	using Bayhaksam.Data.Repository;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;

	public class EFCoreReadRepository<TEntity> : EFCoreRepositoryBase, IReadRepository<TEntity> where TEntity : class
	{
		#region Constructors
		public EFCoreReadRepository(DbContext context) : base(context)
		{
			this.Context = context;
		}
		#endregion

		#region IReadRepository Methods
		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) =>
			this.Context.Set<TEntity>().Where(predicate);

		public IEnumerable<TEntity> GetAll() => this.Context.Set<TEntity>().ToList();

		public TEntity Get(int id) => this.Context.Set<TEntity>().Find(id);

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate) =>
			this.Context.Set<TEntity>().SingleOrDefault(predicate);
		#endregion
	}
}
