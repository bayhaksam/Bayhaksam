//-----------------------------------------------------------------------
// <copyright file="IListExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Collections.Generic.Extensions
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Extensions for <see cref="IList{T}"/> class.
	/// </summary>
	public static class IListExt
	{
		public static void Shuffle<T>(this IList<T> source)
		{
			var random = new Random();
			var n = source.Count;

			while (n > 1)
			{
				n--;
				var k = random.Next(n + 1);
				var value = source[k];
				source[k] = source[n];
				source[n] = value;
			}
		}
	}
}
