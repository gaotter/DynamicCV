using System;
using System.Collections.Generic;
using System.Text;

namespace Knowit.Amende.Helpers.Extensions
{
    public static class DateTimeExtensions
    {
        public static double ToJavaScriptUtcTicks(this DateTime dt)
        {
            var rawTicks = dt.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

            var ticks = rawTicks > 0 ? rawTicks : 1;
            
            return ticks;
        }
    }
}
