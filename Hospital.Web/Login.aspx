<%@ Page Language="C#" AutoEventWireup="true" Inherits="LoginPage" EnableViewState="false"
    ValidateRequest="false" CodeBehind="Login.aspx.cs" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.ExpressApp.Web.Templates.ActionContainers" TagPrefix="cc2" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.ExpressApp.Web.Templates.Controls" TagPrefix="tc" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.ExpressApp.Web.Controls" TagPrefix="cc4" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.ExpressApp.Web.Templates" TagPrefix="cc3" %>
<%@ Register assembly="DevExpress.Web.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title>Logon</title>

    <style type="text/css">
        .LogonContentWidth {
            background: rgba(255,255,255,0.4);
        }

        .CardGroupContent {
            background: rgba(255,255,255,0);
        }

        .Caption {
            color: #07106A;
            font-weight: bold;
        }

        .StaticText {
            color: #000;
        }
		
 
    </style>



</head>
<%--<body class="Dialog" style="background-image: url(images/banner.jpg); background-position: center top; background-repeat: no-repeat; -moz-background-size: cover; -o-background-size: cover; -webkit-background-size: cover; min-height: 750px;">--%>
    <body class="Dialog" style="background-color: cadetblue; center top; background-repeat: no-repeat; -moz-background-size: cover; -o-background-size: cover; -webkit-background-size: cover; min-height: 750px;">
    <div id="PageContent" class="PageContent DialogPageContent">
        <form id="form1" runat="server">
        <cc4:ASPxProgressControl ID="ProgressControl" runat="server" />
        <div id="Content" style="border-bottom: 5px solid #07106A;" runat="server" />
        </form>
    </div>
</body>
</html>
