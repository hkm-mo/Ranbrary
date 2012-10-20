using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranbrary
{
	public static class Rand
	{
		private static Random _rand;
		public static Random rand
		{
			get
			{
				if (_rand == null)
				{
					_rand = new Random();
				}

				return _rand;
			}
		}

		/// <Summary>
		///     Returns a random number within a specified range.
		/// </Summary>
		/// 
		/// <param name="minValue">
		///		The inclusive lower bound of the random number returned.
		/// </param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned. maxValue must be
		///     greater than or equal to minValue.
		/// </param>
		/// 
		/// <returns>
		///		A 32-bit signed integer greater than or equal to minValue and less than maxValue;
		///     that is, the range of return values includes minValue but not maxValue. If
		///     minValue equals maxValue, minValue is returned.
		/// </returns>
		///     
		/// <exception cref="System.ArgumentOutOfRangeException">
		///		minValue is greater than maxValue.
		/// </exception>
		public static int GetInt(int minValue, int maxValue)
		{
			return rand.Next(minValue, maxValue);
		}

		public static int GetInt(int maxValue)
		{
			return rand.Next(maxValue);
		}

		public static int GetInt()
		{
			return GetInt();
		}

		public static void GetBytes(byte[] buffer)
		{
			rand.NextBytes(buffer);
		}

		/// <Summary>
		///     Returns a random number within a specified range.
		/// </Summary>
		/// 
		/// <param name="minValue">
		///		The inclusive lower bound of the random number returned.
		/// </param>
		/// <param name="maxValue">
		///		The exclusive upper bound of the random number returned. maxValue must be
		///     greater than or equal to minValue.
		/// </param>
		/// 
		/// <returns>
		///		A double greater than or equal to minValue and less than maxValue;
		///     that is, the range of return values includes minValue but not maxValue. If
		///     minValue equals maxValue, minValue is returned.
		/// </returns>
		///     
		/// <exception cref="System.ArgumentOutOfRangeException">
		///		minValue is greater than maxValue.
		/// </exception>
		public static double GetDouble(double minValue, double maxValue)
		{
			if (minValue > maxValue)
			{
				throw new ArgumentOutOfRangeException("minValue is greater than maxValue.");
			}
			double randNum = rand.NextDouble();

			double numDelta = maxValue - minValue;

			return randNum * numDelta + minValue;
		}

		public static double GetDouble(double maxValue)
		{
			return rand.NextDouble() * maxValue;
		}

		public static double GetDouble()
		{
			return rand.NextDouble();
		}

		public static T TakeOne<T>(T[] range){
			if (range.Length == 0)
			{
				throw new ArgumentOutOfRangeException("range must have one itme at least.");
			}
			int takeAt = GetInt(range.Length);
			return range[takeAt];
		}

		public static T[] Take<T>(T[] range, int length)
		{
			return Take<T>(range, length, false);
		}

		public static T[] Take<T>(T[] range, int length, bool allowRepeat)
		{
			int rangeLen = range.Length;
			if (rangeLen == 0)
			{
				throw new ArgumentOutOfRangeException("Range must have one itme at least.");
			}
			if (!allowRepeat && rangeLen < length)
			{
				throw new ArgumentOutOfRangeException("Range must longer than number of take.");
			}
			if (length <= 0)
			{
				throw new ArgumentOutOfRangeException("Length must bigger than zero.");
			}

			T[] token = new T[length];

			if (allowRepeat)
			{
				for (int i = 0; i < length; i++)
				{
					token[i] = range[GetInt(rangeLen)];
				}
			}
			else
			{
				int[] tokenIds = new int[length];
				for (int i = 0, step = 0; i < length; i+=step)
				{
					int tokenId = GetInt(rangeLen);
					if (tokenIds.Contains(tokenId))
					{
						step = 0;
					}
					else
					{
						token[i] = range[tokenId];
						tokenIds[i] = tokenId;
						step = 1;
					}
				}
			}

			return token;
		}

	}
}
