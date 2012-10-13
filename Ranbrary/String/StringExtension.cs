using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranbrary.String
{
	public static class StringExtension
	{
		public static char RandomTakeOne(this string str)
		{
			char[] range = str.ToCharArray();
			return Rand.TakeOne(range);
		}

		public static string RandomTake(this string str, int length)
		{
			return str.RandomTake(length, false);
		}

		public static string RandomTake(this string str, int length, bool allowRepeat)
		{
			char[] range = str.ToCharArray();

			return new string(Rand.Take(range, length, allowRepeat));
		}
	}
}
