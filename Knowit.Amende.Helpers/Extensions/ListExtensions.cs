using System;
using System.Collections.Generic;
using System.Text;

namespace Knowit.Amende.Helpers.Extensions
{
    public static class ListExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> itemAction) 
        {
            foreach (var item in enumerable)
            {
                itemAction(item);
            }
        }
    }
}
