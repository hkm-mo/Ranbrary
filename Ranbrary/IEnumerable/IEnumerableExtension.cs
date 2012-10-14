using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace Ranbrary.IEnumerable
{
    public static class IEnumerableExtension
    {
        public static T RandomTakeOne<T>(this IList<T> enumerable)
        {
            if (enumerable == null) throw new ArgumentNullException("enumerable");

            return enumerable[new Random().Next(1, enumerable.Count)]; ;
        }

        public static T RandomTakeOne<K, T>(IDictionary<K, T> dictionary)
        {
            if (dictionary == null) throw new ArgumentNullException("dictionary");

            return dictionary.ElementAt(new Random().Next(1, dictionary.Count)).Value;
        }
    }
}
