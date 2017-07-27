using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdels
{
    [Serializable]
    public class Metrics
    {
        public double LoadTime { get; set; }

        public Int64 Size { get; set; }

        public Int16 CodeQuality { get; set; }

        public Int16 SocialInterest { get; set; }

        public Int16 MetaTags { get; set; }

        public Int16 MobileUsability { get; set; }

    }
}
