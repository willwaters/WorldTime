using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTime
{
    internal static class Common
    {

        public static AutoCompleteStringCollection Timezones = new AutoCompleteStringCollection();
        static ZoneSetup ZoneSetup { get; set; }

        public static void LoadSystemTimezones()
        {
            foreach (var tz in TimeZoneInfo.GetSystemTimeZones())
            {
                Timezones.Add(tz.StandardName);
            }
        }
        public static List<Zone> GetZones()
        {
            var output = new List<Zone>();
            if (ZoneSetup != null)
            {
                var local = ZoneSetup.zones.FirstOrDefault(z => z.IsLocalTime == true);
                var others = ZoneSetup.zones.Where(z => z.IsLocalTime == false).ToList();

                return ZoneSetup.zones;

            }
            return output;
        }

        public static void CreateDebugZones()
        {
            ZoneSetup = new ZoneSetup();
            ZoneSetup.zones = new List<Zone>();
            ZoneSetup.zones.Add(new Zone
            {
                Subtext = "Local",
                IsLocalTime= true,
                Name = "Local time"
            });

            ZoneSetup.zones.Add(new Zone
            {
                Subtext = "Ireland",
                Name = "Dublin",
                Timezone = "Dublin, Edinburgh, Lisbon, London"
            });

            ZoneSetup.zones.Add(new Zone
            {
                Subtext = "New Zealand",
                Name = "Wellington",
                Timezone = "Auckland, Wellington"
            });

        }
    }
}
