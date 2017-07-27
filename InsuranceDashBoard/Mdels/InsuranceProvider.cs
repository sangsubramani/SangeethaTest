using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdels
{
    [Serializable]
    public class InsuranceProvider
        {
            public string Company { get; set; }
            public string Country { get; set; } = "UK";

            public Metrics Metrics { get; set; }

            public Metrics SetMetrics(string provider, double loadTime, Int64 size)
            {
                Metrics metrics = new Metrics();
                if (provider.Equals("Axa", StringComparison.OrdinalIgnoreCase))
                {
                    metrics = LoadAxaData(loadTime, size);
                }
                if (provider.Equals("FirstCentral", StringComparison.OrdinalIgnoreCase))
                {
                    metrics = LoadFirstCentralData(loadTime, size);
                }
                if (provider.Equals("Aviva", StringComparison.OrdinalIgnoreCase))
                {
                    metrics = LoadAvivaData(loadTime, size);
                }
                if (provider.Equals("Aig", StringComparison.OrdinalIgnoreCase))
                {
                    metrics = LoadAigData(loadTime, size);
                }
                return metrics;
            }


            private Metrics LoadAxaData(double loadTime, long size)
            {
                Metrics metrics = new Metrics();
                metrics.LoadTime = loadTime;
                metrics.Size = size;
                metrics.MetaTags = 10;
                metrics.SocialInterest = 8;
                metrics.CodeQuality = 6;
                metrics.MobileUsability = 10;
                return metrics;
            }


            private Metrics LoadFirstCentralData(double loadTime, long size)
            {
                Metrics metrics = new Metrics();
                metrics.LoadTime = loadTime;
                metrics.Size = size;
                metrics.MetaTags = 10;
                metrics.SocialInterest = 9;
                metrics.CodeQuality = 3;
                metrics.MobileUsability = 10;
                return metrics;
            }

            private Metrics LoadAvivaData(double loadTime, long size)
            {
                Metrics metrics = new Metrics();
                metrics.LoadTime = loadTime;
                metrics.Size = size;
                metrics.MetaTags = 10;
                metrics.SocialInterest = 9;
                metrics.CodeQuality = 5;
                metrics.MobileUsability = 10;
                return metrics;
            }

            private Metrics LoadAigData(double loadTime, long size)
            {
                Metrics metrics = new Metrics();
                metrics.LoadTime = loadTime;
                metrics.Size = size;
                metrics.MetaTags = 2;
                metrics.SocialInterest = 5;
                metrics.CodeQuality = 3;
                metrics.MobileUsability = 10;
                return metrics;
            }

        }

    }

