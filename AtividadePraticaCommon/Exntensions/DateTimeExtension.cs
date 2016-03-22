using System;

namespace AtividadePraticaCommon.Exntensions
{
    public static class DateTimeExtension
    {
        public static DateTime MinTimeDay(this DateTime date)
        {
            return TimeDay(date.Year, date.Month, date.Day, 0, 0, 0);
        }

        public static DateTime MaxTimeDay(this DateTime date)
        {
            return TimeDay(date.Year, date.Month, date.Day, 23, 59, 59);
        }

        public static DateTime? MinTimeDay(this DateTime? date)
        {
            return date != null
                ? TimeDay(date.Value.Year, date.Value.Month, date.Value.Day, 0, 0, 0)
                : (DateTime?) null;
        }

        public static DateTime? MaxTimeDay(this DateTime? date)
        {
            return date != null
                ? TimeDay(date.Value.Year, date.Value.Month, date.Value.Day, 23, 59, 59)
                : (DateTime?) null;
        }

        private static DateTime TimeDay(int year, int month, int day, int hour, int minute, int second)
        {
            return new DateTime(year, month, day, hour, minute, second);
        }
    }
}
