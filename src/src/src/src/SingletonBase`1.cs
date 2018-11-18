//-----------------------------------------------------------------------
// <copyright file="SingletonBase`1.cs" company="Simsoft">
//      Copyright (c) Simsoft. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam
{
	public abstract class SingletonBase<T> : SingletonBase<T, T> where T : new()
	{
		#region Protected Constructors
		protected SingletonBase() : base()
		{
		}
		#endregion
	}
}
