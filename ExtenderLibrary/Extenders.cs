namespace ExtenderLibrary
{
    using System;
    using System.Collections.Generic;

    public static class Extenders
    {
        public static bool IsOrdered<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            T lastItem = default(T);
            bool isFirst = true;
            foreach (var item in data)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    if (item.CompareTo(lastItem) < 0)
                    {
                        return false;
                    }
                }

                lastItem = item;
            }

            return true;
        }

        public static bool IsOrdered<T>(this IEnumerable<T> data, IComparer<T> comparer)
        {
            T lastItem = default(T);
            bool isFirst = true;
            foreach (var item in data)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    if (comparer.Compare(item, lastItem) < 0)
                    {
                        return false;
                    }
                }

                lastItem = item;
            }

            return true;
        }
    }
}
