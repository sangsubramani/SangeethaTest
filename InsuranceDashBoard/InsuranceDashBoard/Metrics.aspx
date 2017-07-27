<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Metrics.aspx.cs" Inherits="InsuranceDashBoard.Metrics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body style="padding-top: 60px">
    <nav class="navbar navbar-inverse" style="background-color: #708090;">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Insurance SiteCompare</a>
            </div>
            <ul class="nav navbar-nav">
                 <li><a href="Index.aspx">Home</a></li>
                <li><a href="DashBoard.aspx">DashBoard</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="well-sm">
            <div class="Container">
                <div class="jumbotron pull-left">
                    <h1>
                        <asp:Label ID="lblHeading" runat="server"></asp:Label></h1>
                    <p>Metrics data for the site</p>
                </div>
            </div>
            <div class="alert-info">
                <table class="table table-striped">
                    <colgroup>
                        <col class="col-md-7" />
                        <col class="col-md-4" />
                    </colgroup>
                    <tr>
                        <td class="bg-primary">
                            <asp:Label ID="lblLoadText" runat="server" Text="Load Time :"></asp:Label>
                        </td>
                        <td class="bg-primary">
                            <asp:Label ID="lblLoadTime" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bg-primary">
                            <asp:Label ID="lblSizeText" runat="server" Text="Size:"></asp:Label>
                        </td>
                        <td class="bg-primary">
                            <asp:Label ID="lblSize" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bg-primary">
                            <asp:Label ID="lblCodeQualityText" runat="server" Text="CodeQuality:"></asp:Label>
                        </td>
                        <td class="bg-primary">
                            <asp:Label ID="lblCodeQuality" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bg-primary">
                            <asp:Label ID="lblSocialInterestText" runat="server" Text="SocialInterest:"></asp:Label>
                        </td>
                        <td class="bg-primary">
                            <asp:Label ID="lblSocialInterest" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bg-primary">
                            <asp:Label ID="lblMetaTagsText" runat="server" Text="MetaTags:"></asp:Label>
                        </td>
                        <td class="bg-primary">
                            <asp:Label ID="lblMetaTags" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="bg-primary">
                            <asp:Label ID="lblMobileUsabilityText" runat="server" Text="MobileUsability:"></asp:Label>
                        </td>
                        <td class="bg-primary">
                            <asp:Label ID="lblMobileUsability" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>

            </div>

        </div>
    </form>
</body>
</html>

