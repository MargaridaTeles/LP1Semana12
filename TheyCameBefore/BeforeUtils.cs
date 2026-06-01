using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T pivot) where T : struct, IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(pivot) < 0)
                    yield return item;
            }
        }
    }
}