using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WorldTime
{
    internal static class Common
    {

        public static AutoCompleteStringCollection Timezones = new AutoCompleteStringCollection();
        public static List<string> TimezonesFullNames = new List<string>();
        static ZoneSetup ZoneSetup { get; set; }

        private static readonly string SaveLocation = "C:/Program Files/WorldTime/zones.json";
        public static void LoadSystemTimezones()
        {
            foreach (var tz in TimeZoneInfo.GetSystemTimeZones())
            {
                char[] chDelimiter = { ')' };
                Timezones.Add(tz.DisplayName.Split(chDelimiter, 2)[1].Trim());
                TimezonesFullNames.Add(tz.DisplayName);
            }
        }
        public static void SaveZoneSetup(ZoneSetup zoneSetup)
        {
            ZoneSetup = zoneSetup;
            var jstr = JsonSerializer.Serialize<ZoneSetup>(zoneSetup);
            FileSystem.WriteAllText(SaveLocation, jstr , false);
        }

        public static void LoadZoneSetup()
        {
            try
            {
                var str = FileSystem.ReadAllText(SaveLocation);
                ZoneSetup = JsonSerializer.Deserialize<ZoneSetup>(str);

                if(ZoneSetup.zones == null || ZoneSetup.zones.Count == 0)
                {
                    CreateDebugZones();
                }

                if (ZoneSetup.zones.Where(z => z.IsLocalTime == true).FirstOrDefault() == null)
                {
                    ZoneSetup.zones.Add(new Zone
                    {
                        Subtext = "Local",
                        IsLocalTime = true,
                        Name = "Local time"
                    });
                }
            } catch
            {
                CreateDebugZones();
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
                Subtext = "Switzerland",
                Name = "Zurich",
                Timezone = "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna"
            });

            ZoneSetup.zones.Add(new Zone
            {
                Subtext = "Ireland",
                Name = "Dublin",
                Timezone = "(UTC+00:00) Dublin, Edinburgh, Lisbon, London"
            });

            ZoneSetup.zones.Add(new Zone
            {
                Subtext = "New Zealand",
                Name = "Wellington",
                Timezone = "(UTC+12:00) Auckland, Wellington"
            });

        }
    }
}
