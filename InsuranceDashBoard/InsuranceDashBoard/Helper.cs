using Mdels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Linq;

namespace InsuranceDashBoard
{
    public static  class Helper
    {
        public static List<InsuranceProvider> ProviderList
        {
            get { return (List<InsuranceProvider>)HttpContext.Current.Session["ProviderData"]; }
            set { HttpContext.Current.Session["ProviderData"] = value; }
        }

        public static  void ConvertListToXML()
        {
            try
            {
                var xElement = new XElement("InsuranceProvider",
                    from provider in ProviderList
                    select new XElement("Provider",
                    new XElement("Company", provider.Company),
                    new XElement("LoadTime", provider.Metrics.LoadTime),
                    new XElement("CodeQuality", provider.Metrics.CodeQuality),
                    new XElement("Size", provider.Metrics.Size),
                    new XElement("SocialInterest", provider.Metrics.SocialInterest),
                    new XElement("MobileUsability", provider.Metrics.MobileUsability),
                    new XElement("MetaTags", provider.Metrics.MetaTags)
                    ));

                xElement.Save(System.Web.HttpContext.Current.Server.MapPath("~/Provider.xml"));
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public static string ReturnUrl(string company)
        {
            string url = string.Empty;
            switch (company)
            {
                case "Axa":
                    url = "http://axa.co.uk";
                    break;

                case "FirstCentral":
                    url = "https://www.1stcentralinsurance.com/";
                    break;

                case "Aviva":
                    url = "https://www.aviva.co.uk/";
                    break;

                case "Aig":
                    url = "https://www.aig.co.uk/";
                    break;

            }
            return url;
        }

        public static double CalculateLoadTime(string url)
        {
            WebClient webClient = new WebClient();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string result = webClient.DownloadString(url);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalSeconds;

        }

        public static long CalculateSizeInBytes(string url)
        {
            WebClient webClient = new WebClient();
            byte[] result = webClient.DownloadData(url);
            return (result.Length);
        }

        public static double ConvertBytesToMegaBytes(Int64 value)
        {
            return (value / 1024f);
        }



    }
}