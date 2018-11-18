//-----------------------------------------------------------------------
// <copyright file="CharExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Extensions
{
	/// <summary>
	/// Extensions for <see cref="char"/> class.
	/// </summary>
	public static class CharExt
	{
		public static bool IsNotWhitespace(this char source) => source != ' ';

		public static bool IsWhitespace(this char source) => source == ' ';
	}
}
