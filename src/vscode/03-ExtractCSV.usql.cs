using System;
using System.Collections.Generic;
using System.Globalization;

namespace Meetup 
{
    public static class ExtractCSV 
    {

        static Lazy<Dictionary<string, string>> Countries = new Lazy<Dictionary<string, string>>(() =>
        {
            var result = new Dictionary<string, string>();
            var cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (var culture in cultures)
            {
                try
                {
                    var region = new RegionInfo(culture.LCID);
                    result[region.TwoLetterISORegionName.ToLowerInvariant()] = region.EnglishName;
                }
                catch
                {                    
                }
            }

            return result;
        });

        public static DateTime FromUnixTime(long unixTime)
        {
            return epochStart.AddSeconds(unixTime);
        }
        private static readonly DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


        public static DateTime? GetDateTimeFromEpochMilliseconds(object input)
        {
            if (input == null)
            {
                return null;
            }

            var epochText = input.ToString();
            if (string.IsNullOrEmpty(epochText))
                return null;

            long epoch = 0;
            if (long.TryParse(epochText, out epoch))
            {
                if (epoch > 0)
                    return FromUnixTime(epoch / 1000);
            }

            return null;
        }

        public static string GetCountryName(object input)
        {
            if (input == null)
                return string.Empty;

            var countryCode = input.ToString();
            if (!string.IsNullOrEmpty(countryCode))
            {
                var countryName = string.Empty;
                if (Countries.Value.TryGetValue(countryCode.ToLowerInvariant(), out countryName))
                {
                    return countryName;
                }
            }

            return countryCode;
        }
    }
}