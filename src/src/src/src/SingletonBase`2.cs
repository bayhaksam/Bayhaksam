//-----------------------------------------------------------------------
// <copyright file="SingletonBase`2.cs" company="Simsoft">
//      Copyright (c) Simsoft. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam
{
	using System;

	public abstract class SingletonBase<TInstance, TConcrete> where TConcrete : TInstance, new()
	{
		#region Protected Constructors
		protected SingletonBase()
		{
		}
		#endregion

		#region Static Properties
		/// <summary>
		/// Gets singleton instance.
		/// </summary>
		public static TInstance Instance => LazyInstance.Value;
		#endregion

		#region Static Protected Properties
		/// <summary>
		/// Gets value for lazy initialization.
		/// </summary>
		protected static Lazy<TInstance> LazyInstance { get; } = new Lazy<TInstance>(() => new TConcrete());
		#endregion
	}
}
