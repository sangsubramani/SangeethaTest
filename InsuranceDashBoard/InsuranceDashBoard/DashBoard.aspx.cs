using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsuranceDashBoard
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Helper.ProviderList != null && Helper.ProviderList.Count >=4)
            {
                Helper.ConvertListToXML();
                LoadChart();
            }
            else
            {
                lblError.Text = "Please load all the sites to generate the XML";
            }
        }

        private  void LoadChart()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(HttpContext.Current.Server.MapPath("~/Provider.xml"));
            LoadTimeChart.Series["LoadTimeSeries"].XValueMember = "Company";
            LoadTimeChart.Series["LoadTimeSeries"].YValueMembers = "LoadTime";
            LoadTimeChart.ChartAreas[0].AxisX.Title = "Insurance Provider";
            LoadTimeChart.ChartAreas[0].AxisY.Title = "Url Load Time in seconds";
            LoadTimeChart.DataSource = ds;
            LoadTimeChart.DataBind();
        }
    }
}