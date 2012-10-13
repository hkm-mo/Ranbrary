using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranbrary.String
{
	public static class RandString
	{
		private static char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
										  'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

		private static char[] serialNumElm = 
					{ 
						'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
						'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
						'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
					};

		public static string GenString(int length)
		{
			return new string(Rand.Take(letters, length, true));
		}

		public static string GenSerialNummber(int segmentLength, int segmentCount, char segmentSeparator)
		{
			if (segmentLength < 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (segmentCount < 1)
			{
				throw new ArgumentOutOfRangeException();
			}

			
			StringBuilder serialNum = new StringBuilder();
			bool isFirstSegment = true;
			for (int i = 0; i < segmentCount; i++)
			{
				if (!isFirstSegment)
				{
					serialNum.Append(segmentSeparator);
				}
				else
				{
					isFirstSegment = false;
				}
				serialNum.Append(Rand.Take(letters, segmentLength, true));
			}

			return serialNum.ToString();
		}
	}
}
