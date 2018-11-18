//-----------------------------------------------------------------------
// <copyright file="StringExt.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Extensions
{
	using System;
	using System.Linq;

	/// <summary>
	/// Extensions for <see cref="string"/> class.
	/// </summary>
	public static class StringExt
	{
		/// <summary>
		/// Appends new line the end of the <paramref name="source"/>.
		/// </summary>
		/// <param name="source">The string</param>
		/// <returns>Returns appended new string.</returns>
		public static string AppendNewLineEnd(this string source) => source + Environment.NewLine;

		/// <summary>
		/// Appends new line the start of the <paramref name="source"/>.
		/// </summary>
		/// <param name="source">The string</param>
		/// <returns>Returns appended new string.</returns>
		public static string AppendNewLineStart(this string source) => Environment.NewLine + source;

		/// <summary>
		/// Gets index of first digit.
		/// <para>Returns -1 when not found any digit.</para>
		/// </summary>
		/// <param name="source">The string</param>
		/// <returns>Returns index of first digit.</returns>
		public static int IndexOfFirstDigit(this string source)
		{
			for (var i = 0; i < source.Length; i++)
			{
				if (char.IsDigit(source[i]))
				{
					return i;
				}
			}

			return -1;
		}

		/// <summary>
		/// Gets index of first letter.
		/// <para>Returns -1 when not found any letter.</para>
		/// </summary>
		/// <param name="source">The string</param>
		/// <returns>Returns index of first letter.</returns>
		public static int IndexOfFirstLetter(this string source)
		{
			for (var i = 0; i < source.Length; i++)
			{
				if (char.IsLetter(source[i]))
				{
					return i;
				}
			}

			return -1;
		}

		/// <summary>
		/// Determines the index of the nth occurrence of value in the string.
		/// <para>Returns -1 when not found.</para>
		/// </summary>
		/// <param name="source">The string</param>
		/// <param name="value">The search begins from start index</param>
		/// <param name="n">Which occurrence ?</param>
		/// <returns>Returns the index of the nth occurrence of value in the string.</returns>
		public static int IndexOfNth(this string source, char value, int n) => source.IndexOfNth(value, 0, n);

		/// <summary>
		/// Determines the index of the nth occurrence of value in the string.
		/// <para>Returns -1 when not found.</para>
		/// </summary>
		/// <param name="source">The string</param>
		/// <param name="value">The value</param>
		/// <param name="startIndex">The search begins from start index</param>
		/// <param name="n">Which occurrence ?</param>
		/// <returns>Returns the index of the nth occurrence of value in the string.</returns>
		public static int IndexOfNth(this string source, char value, int startIndex, int n)
		{
			if (source == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			if (startIndex < 0 || startIndex > source.Length)
			{
				throw new ArgumentOutOfRangeException(
					nameof(startIndex),
					"Index was out of range. Must be non-negative and less than the size of the collection");
			}

			if (n < 0 || startIndex > source.Length - n)
			{
				throw new ArgumentOutOfRangeException(
					nameof(n),
					"n must be positive and count must refer to a location within the string.");
			}

			var count = 0;
			for (var i = startIndex; i < source.Length; i++)
			{
				if (source[i] == value)
				{
					count++;
					if (count == n)
					{
						return i;
					}
				}
			}

			return -1;
		}

		public static bool IsBlank(this string source) => source.Length == 0 || source.All(ch => ch.IsWhitespace());

		public static bool IsEmpty(this string source) => source.Length == 0;

		public static bool IsEmptyOrWhitespace(this string source) => source.Length == 0 || source == " ";

		public static bool IsNotBlank(this string source) => !source.IsBlank();

		public static bool IsNotEmpty(this string source) => source.Length > 0;

		public static bool IsNotWhitespace(this string source) => source != " ";

		public static bool IsNullOrBlank(this string source) => source == null || source.IsBlank();

		public static bool IsNullOrEmpty(this string source) => string.IsNullOrEmpty(source);

		public static bool IsNullOrWhiteSpace(this string source) => string.IsNullOrWhiteSpace(source);

		public static bool IsWhitespace(this string source) => source == " ";
	}
}
