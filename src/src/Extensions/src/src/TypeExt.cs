//-----------------------------------------------------------------------
// <copyright file="TypeExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// <see cref="Type"/>' s extension class
	/// </summary>
	public static class TypeExt
	{
		public static IEnumerable<Type> GetConcreteTypes(this Type type) =>
			type.Assembly.GetTypes().Where(x => !x.IsAbstract);

		public static IEnumerable<Type> GetConcreteTypesSubclassOf(this Type type) =>
			type.Assembly.GetTypes().Where(x => !x.IsAbstract && x.IsSubclassOf(type));
	}
}
