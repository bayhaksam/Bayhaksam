//-----------------------------------------------------------------------
// <copyright file="ObjectExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Extensions
{
	/// <summary>
	/// <see cref="object"/>' s extension class
	/// </summary>
	public static class ObjectExt
	{
		/// <summary>
		/// <paramref name="obj"/>
		///		is a
		///		<typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">Type to detect
		///		<paramref name="obj"/>
		///		is a
		///		<typeparamref name="T"/>
		///		.
		///	</typeparam>
		/// <param name="obj">Object.</param>
		/// <returns>Returns if the object is
		///		<typeparamref name="T"/>
		///		.
		///	</returns>
		public static bool Is<T>(this object obj)
		{
			return obj is T;
		}

		/// <summary>
		/// <paramref name="obj"/>
		///		is not a
		///		<typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">Type to detect
		///		<paramref name="obj"/>
		///		is not a
		///		<typeparamref name="T"/>
		///		.
		///	</typeparam>
		/// <param name="obj">Object.</param>
		/// <returns>Returns if the object is
		///		<typeparamref name="T"/>
		///		.
		///	</returns>
		public static bool IsNot<T>(this object obj)
		{
			return !(obj is T);
		}
	}
}
