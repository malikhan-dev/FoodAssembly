using System.Security.Cryptography;

namespace FoodAssembly.Utilities
{
    public static class DateHelper
    {
        public static string CalculateDiff(DateTime TargetDate)
        {
            var diff = TargetDate - DateTime.Now;

            return string.Concat(
                                        diff.Hours.ToString().Length > 1 ? diff.Hours.ToString() : string.Concat("0", diff.Hours.ToString()), ":",
                                        diff.Minutes.ToString().Length > 1 ? diff.Minutes.ToString() : string.Concat("0", diff.Minutes.ToString()), ":",
                                        diff.Seconds.ToString().Length > 1 ? diff.Seconds.ToString() : string.Concat("0", diff.Seconds.ToString()));

        }
    }
}
