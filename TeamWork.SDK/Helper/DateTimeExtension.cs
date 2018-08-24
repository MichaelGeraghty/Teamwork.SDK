using System;
using System.Globalization;

namespace TeamWork.SDK.Helper
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// Convert a string to DateTime Max with provided format
        /// </summary>
        /// <param name="s">date string</param>
        /// <param name="format">format</param>
        /// <returns>Max value of a date 23:59:59.9999999 UTC, December 31, 9999 in the Gregorian calendar</returns>
        public static DateTime ToDateTimeExactMax(this string s, string format)
        {
            DateTime date;
            if (DateTime.TryParseExact(
              s,
              format,
              CultureInfo.InvariantCulture,
              DateTimeStyles.None,
              out date))
            {
                return date;
            }
            return DateTime.MaxValue;
        }

        /// <summary>
        /// Convert a string to DateTime Max
        /// </summary>
        /// <param name="s">date string yyyymmdd</param>
        /// <returns>Max value of a date 23:59:59.9999999 UTC, December 31, 9999 in the Gregorian calendar</returns>
        public static DateTime ToDateTimeExactMax(this string s)
        {
            string[] format = { "yyyyMMdd" };
            DateTime date;
            if (DateTime.TryParseExact(
              s,
              format,
              CultureInfo.InvariantCulture,
              DateTimeStyles.None,
              out date))
            {
                return date;
            }
            return DateTime.MaxValue;
        }

        /// <summary>
        /// Convert a string to DateTime Min
        /// </summary>
        /// <param name="s">date string yyyymmdd</param>
        /// <returns>The value of this constant is equivalent to 00:00:00.0000000 UTC, January 1, 0001, in the Gregorian calendar.</returns>
        public static DateTime ToDateTimeExactMin(this string s)
        {
            string[] format = { "yyyyMMdd" };
            DateTime date;
            if (DateTime.TryParseExact(
              s,
              format,
              CultureInfo.InvariantCulture,
              DateTimeStyles.None,
              out date))
            {
                return date;
            }
            return DateTime.MinValue;
        }
        /// <summary>
        /// Convert a string to DateTime Min
        /// </summary>
        /// <param name="s">date string yyyymmdd</param>
        /// <param name="format">format</param>
        /// <returns>The value of this constant is equivalent to 00:00:00.0000000 UTC, January 1, 0001, in the Gregorian calendar.</returns>
        public static DateTime ToDateTimeExactMin(this string s, string format)
        {
            DateTime date;
            if (DateTime.TryParseExact(
              s,
              format,
              CultureInfo.InvariantCulture,
              DateTimeStyles.None,
              out date))
            {
                return date;
            }
            return DateTime.MinValue;
        }
    }
}
