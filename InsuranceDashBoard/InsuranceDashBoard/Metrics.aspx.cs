using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InsuranceDashBoard;
using Mdels;
using System.Xml.Linq;

namespace InsuranceDashBoard
{
    
    public partial class Metrics : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Helper.ProviderList == null) Helper.ProviderList = new List<InsuranceProvider>();

            var companyName = Convert.ToString(Request.QueryString["name"]);
            if (!string.IsNullOrWhiteSpace(companyName))
            {
                lblHeading.Text = companyName.ToUpperInvariant();
                var url = Helper.ReturnUrl(companyName);
                
                var loadTime = Helper.CalculateLoadTime(url);
               
                var size = Helper.CalculateSizeInBytes(url);
               
                var provider = InitializeMetricsData(companyName, loadTime, size);
                ShowMetricsData(provider);

            }
            
        }

        private InsuranceProvider InitializeMetricsData(string companyName, double loadTime, long size)
        {
            InsuranceProvider insuranceProvider = new InsuranceProvider();
            insuranceProvider.Company = companyName;
            insuranceProvider.Metrics = insuranceProvider.SetMetrics(companyName, loadTime, size);
            
            StoreInSession(insuranceProvider);
            return insuranceProvider;
        }

        private void ShowMetricsData(InsuranceProvider provider)
        {
            lblLoadTime.Text = provider.Metrics.LoadTime + "S";
            lblSize.Text = Helper.ConvertBytesToMegaBytes(provider.Metrics.Size) + "MB";
            lblSocialInterest.Text = provider.Metrics.SocialInterest.ToString();
            lblMobileUsability.Text = provider.Metrics.MobileUsability.ToString();
            lblCodeQuality.Text = provider.Metrics.CodeQuality.ToString();
            lblMetaTags.Text = provider.Metrics.MetaTags.ToString();
        }

        private void StoreInSession(InsuranceProvider provider)
        {
            if (!Helper.ProviderList.Any(p=>p.Company == provider.Company))
                Helper.ProviderList.Add(provider);
        }


        

      

       
    }
}