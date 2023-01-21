using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTime
{
    internal class Zone
    {
        public string Name { get; set; }
        public string Subtext { get; set; }
        public string Timezone { get; set; }
        public bool IsLocalTime { get; set; }
    }
}
