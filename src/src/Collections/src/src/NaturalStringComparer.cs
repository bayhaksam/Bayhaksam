//-----------------------------------------------------------------------
// <copyright file="NaturalStringComparer.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Collections
{
	using System;
	using System.Collections.Generic;
	using System.Text.RegularExpressions;

	public class NaturalStringComparer : Comparer<string>, IDisposable
	{
		#region Fields
		Dictionary<string, string[]> dic = new Dictionary<string, string[]>();
		#endregion

		#region Public Methods
		#region Comparer Methods
		/// <inheritdoc />
		public override int Compare(string x, string y)
		{
			if (x == y)
			{
				return 0;
			}

			if (!this.dic.TryGetValue(x, out string[] x1))
			{
				x1 = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
				this.dic.Add(x, x1);
			}

			if (!this.dic.TryGetValue(y, out string[] y1))
			{
				y1 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");
				this.dic.Add(y, y1);
			}

			for (var i = 0; i < x1.Length && i < y1.Length; i++)
			{
				if (x1[i] != y1[i])
				{
					return this.PartCompare(x1[i], y1[i]);
				}
			}

			if (y1.Length > x1.Length)
			{
				return 1;
			}

			if (x1.Length > y1.Length)
			{
				return -1;
			}

			return 0;
		}
		#endregion

		#region IDisposable Methods
		/// <inheritdoc />
		public void Dispose()
		{
			this.dic.Clear();
			this.dic = null;
		}
		#endregion
		#endregion

		#region Methods
		int PartCompare(string left, string right)
		{
			if (!int.TryParse(left, out int x))
			{
				return left.CompareTo(right);
			}

			if (!int.TryParse(right, out int y))
			{
				return left.CompareTo(right);
			}

			return x.CompareTo(y);
		}
		#endregion
	}
}
