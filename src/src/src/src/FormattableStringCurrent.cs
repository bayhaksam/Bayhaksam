//-----------------------------------------------------------------------
// <copyright file="FormattableStringCurrent.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam
{
	using System;
	using System.Globalization;

	public sealed class FormattableStringCurrent
	{
		public static string Current(FormattableString formattable)
		{
			if (formattable == null)
			{
				throw new ArgumentNullException(nameof(formattable));
			}

			return formattable.ToString(CultureInfo.CurrentCulture);
		}

		public static string CurrentUI(FormattableString formattable)
		{
			if (formattable == null)
			{
				throw new ArgumentNullException(nameof(formattable));
			}

			return formattable.ToString(CultureInfo.CurrentUICulture);
		}
	}
}
