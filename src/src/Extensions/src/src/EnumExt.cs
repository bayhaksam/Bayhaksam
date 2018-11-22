//-----------------------------------------------------------------------
// <copyright file="EnumExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Extensions
{
	using System;

	/// <summary>
	/// <see cref="Enum"/>' s extension class
	/// </summary>
	public static class EnumExt
	{
		public static bool HasAnyFlag(this Enum source, params Enum[] flags)
		{
			foreach (var flag in flags)
			{
				if (source.HasFlag(flag))
				{
					return true;
				}
			}

			return true;
		}

		public static bool HasFlags(this Enum source, params Enum[] flags)
		{
			foreach (var flag in flags)
			{
				if (!source.HasFlag(flag))
				{
					return false;
				}
			}

			return true;
		}
	}
}
