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
		public static bool IsSameDay(this DateTime source, DateTime value) =>
			source.Year == value.Year && source.Month == value.Month && source.Day == value.Day;

		public static bool IsSameHour(this DateTime source, DateTime value) =>
			source.Year == value.Year
				&& source.Month == value.Month
				&& source.Day == value.Day
				&& source.Hour == value.Hour;

		public static bool IsSameMillisecond(this DateTime source, DateTime value) =>
			source.Year == value.Year
				&& source.Month == value.Month
				&& source.Day == value.Day
				&& source.Hour == value.Hour
				&& source.Minute == value.Minute
				&& source.Second == value.Second
				&& source.Millisecond == value.Millisecond;

		public static bool IsSameMinute(this DateTime source, DateTime value) =>
			source.Year == value.Year
				&& source.Month == value.Month
				&& source.Day == value.Day
				&& source.Hour == value.Hour
				&& source.Minute == value.Minute;

		public static bool IsSameMonth(this DateTime source, DateTime value) =>
			source.Year == value.Year && source.Month == value.Month;

		public static bool IsSameSecond(this DateTime source, DateTime value) =>
			source.Year == value.Year
				&& source.Month == value.Month
				&& source.Day == value.Day
				&& source.Hour == value.Hour
				&& source.Minute == value.Minute
				&& source.Second == value.Second;

		public static bool IsSameYear(this DateTime source, DateTime value) => source.Year == value.Year;

		public static string ToLongTimeStampString(this DateTime source) => source.ToString("yyyyMMddHHmmssfffffff");
	}
}
