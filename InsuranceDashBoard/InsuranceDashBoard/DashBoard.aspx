<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="InsuranceDashBoard.DashBoard" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body style="padding-top:40px">
   <nav class="navbar navbar-inverse" style="background-color: #708090;">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">Insurance SiteCompare</a>
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="DashBoard.aspx">DashBoard</a></li>
      <li><a href="Index.aspx">Home</a></li>
    
    </ul>
  </div>
</nav>
    <form id="form1" runat="server">
    <div class="container">
    <div>
        <asp:Label ID="lblError" Text="" runat="server" style="font-weight:bolder; color:red"></asp:Label>
    </div>
   <div class="wells">
        <asp:Chart ID="LoadTimeChart" runat="server"  BorderSkin-BackGradientStyle="DiagonalLeft" Height ="350px" Width="500px" BackColor="LightBlue">
            <Series>
                <asp:Series Name="LoadTimeSeries"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="LoadTimeChartArea"  ></asp:ChartArea>
            </ChartAreas>
            
           

<BorderSkin BackGradientStyle="DiagonalLeft"></BorderSkin>
            
        </asp:Chart>
   </div>
    </div>
       
    </form>
</body>
</html>
