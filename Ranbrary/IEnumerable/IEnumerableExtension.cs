using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranbrary.IEnumerable
{
	public static class IEnumerableExtension
	{
		public static T RandomTakeOne<T>(this IList<T> enumerable)
		{

			T token = enumerable[6];
			return token;
			//return Rand.TakeOne(range);
		}
	}
}
