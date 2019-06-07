//-----------------------------------------------------------------------
// <copyright file="EFCoreRepository`1.cs" company="Bayhaksam">
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

	public class EFCoreRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		#region Constructors
		public EFCoreRepository(DbContext context)
		{
			this.Context = context;
		}
		#endregion

		#region Protected Properties
		protected DbContext Context { get; set; }
		#endregion

		#region IRepository Methods
		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) =>
			this.Context.Set<TEntity>().Where(predicate);

		public IEnumerable<TEntity> GetAll() => this.Context.Set<TEntity>().ToList();

		public TEntity Get(int id) => this.Context.Set<TEntity>().Find(id);

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate) =>
			this.Context.Set<TEntity>().SingleOrDefault(predicate);

		public void Add(TEntity entity) => this.Context.Set<TEntity>().Add(entity);

		public void AddRange(IEnumerable<TEntity> entities) => this.Context.Set<TEntity>().AddRange(entities);

		public void Remove(TEntity entity) => this.Context.Set<TEntity>().Remove(entity);

		public void RemoveRange(IEnumerable<TEntity> entities) => this.Context.Set<TEntity>().RemoveRange(entities);
		#endregion
	}
}
