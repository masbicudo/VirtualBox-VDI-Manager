using System;
using System.Collections.Generic;

namespace VBoxVdiManager
{
    public static class ObjectExtensions
    {
        public static IEnumerable<T> GetPath<T>(this T o, Func<T, T> fnext)
        {
            while (o != null)
            {
                yield return o;
                o = fnext(o);
            }
        }
    }
}
