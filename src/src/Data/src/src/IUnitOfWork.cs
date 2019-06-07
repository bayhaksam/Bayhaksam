//-----------------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Data
{
	using System;
	using System.Threading.Tasks;

	public interface IUnitOfWork : IDisposable
	{
		Task CompleteAsync();

		void Complete();
	}
}
