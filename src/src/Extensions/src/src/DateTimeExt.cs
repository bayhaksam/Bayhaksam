//-----------------------------------------------------------------------
// <copyright file="DateTimeExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Extensions
{
	using System;

	/// <summary>
	/// <see cref="DateTime"/>' s extension class
	/// </summary>
	public static class DateTimeExt
	{
		public static string ToLongTimeStampString(this DateTime source) => source.ToString("yyyyMMddHHmmssfffffff");
	}
}
