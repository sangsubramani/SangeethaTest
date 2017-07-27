<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="InsuranceDashBoard.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-3.1.1.min.js"></script>
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
      <li class="active"><a href="Index.aspx">Home</a></li>
      <li><a href="DashBoard.aspx">DashBoard</a></li>
    
    </ul>
  </div>
</nav>
    <form id="form1" runat="server">
        <div class="col col-lg-12 col-sm-12">
         <div class="well">
            <table class="table-bordered" style="border:thick;color:black">
                <tr class="alert-warning">
                  
                    <td>
                        <div>
                            <input type="button" class="btn-success pull-right"  id="btnAxa" value="Know More..." name="Axa" />
                            
                        </div>
                        <iframe id="iAxaWebFrame" runat="server" frameborder="2" src="http://axa.co.uk" width="750" height="500"></iframe>
                    </td>
                      <td style="padding-right:50px">&nbsp;</td>
                    <td>
                        <div>
                            <input type="button" class="btn-success pull-right"  id="btnFirstCentral" value="Know More..."  name="FirstCentral"/>
                        </div>
                        <iframe id="iFirstCentralWebFrame" runat="server" frameborder="2" src="https://www.1stcentralinsurance.com/" width="750" height="500"></iframe>
                    </td>
                </tr>
            </table>
            
            <table class="table-bordered" style="border:double;color:aliceblue">
              
                 <tr class="alert-warning">
                        <td>
                            <div>
                                <input type="button" class="btn-success pull-right"  id="btnAviva" value="Know More..."  name="Aviva"/>
                            </div>
                            <iframe id="iAvivaWebFrame" runat="server" frameborder="2" src="https://www.aviva.co.uk/" width="750" height="500" allowfullscreen="true"></iframe>
                        </td>
                     <td style="padding-right:50px">&nbsp;</td>
                        <td>
                            <div>
                                 <input type="button" class="btn-success pull-right"  id="btnAig" value="Know More..."  name="Aig"/>
                            </div>
                            <iframe id="iAigWebFrame" runat="server" frameborder="2" src="https://www.aig.co.uk/" width="750" height="500" allowfullscreen="true"></iframe>
                        </td>
                    </tr>
              
            </table>
             </div>
        </div>
          
    </form>
</body>
    <script type="text/javascript">
        $(document).ready(function(){
            $('.btn-success').click(function () {
                var selectedCompany = $(this).attr("name");
                window.location.href = "Metrics.aspx?name=" + selectedCompany + "";
            });
        });
    </script>
</html>