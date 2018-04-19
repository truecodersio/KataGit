using System;
using System.Collections.Generic;
using System.Linq;

namespace GitKata.Shared
{
    public static class EnumerableHelpers
    {
        /// <summary>
        /// Gets a random element out of the collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T GetRandom<T>(this IEnumerable<T> collection)
        {
            var col = collection as T[] ?? collection.ToArray();
            if (!col.Any()) return default(T);
            var rand = new Random(DateTime.Now.Millisecond);
            var index = rand.Next(col.Count());
            return col.ToArray()[index];
        }
    }
}
