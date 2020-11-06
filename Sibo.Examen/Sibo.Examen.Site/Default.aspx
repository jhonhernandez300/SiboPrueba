<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sibo.Examen.Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sibo SuperMarket</title>
    <link href="css/site.css" rel="stylesheet" />
    <%--For Messages--%>
    <script src="scripts/jquery-1.9.1.js"></script>
    <script src="scripts/jquery.msgBox.js" type="text/javascript"></script>
    <link href="css/msgBoxLight.css" rel="stylesheet" type="text/css">
    <%--End Messages--%>
    <script src="scripts/general.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Container">
        <div class="LogoLogin">
            <img src="images/logo.png" width="100" />
            <h1>Sibo SuperMarket</h1>
        </div>
        <div class="Login">
            <div>
                <div>Identificación:</div><asp:TextBox ID="txtUser" MaxLength="20" runat="server"></asp:TextBox>
            </div>
            <div>
                <div>Contraseña:</div><asp:TextBox ID="txtPassword" MaxLength="10" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <div style="text-align:center">
                <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click"></asp:Button>
            </div>
        </div>
    </div>
        <asp:Literal runat="server" ID="ltScript"></asp:Literal>
    </form>
</body>
</html>
