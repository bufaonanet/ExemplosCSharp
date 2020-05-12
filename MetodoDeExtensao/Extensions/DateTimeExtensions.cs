using System.Globalization;

namespace System
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F2", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F2", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
