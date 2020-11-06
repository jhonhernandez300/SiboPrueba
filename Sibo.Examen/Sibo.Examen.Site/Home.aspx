<%@ Page Title="" Language="C#" MasterPageFile="~/examen.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Sibo.Examen.Site.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Form">
        <br />
        <asp:Label ID="Label1" runat="server" Text="AdviserID"></asp:Label>
&nbsp;
        <asp:Label ID="labAdviserID" runat="server" Text="0"></asp:Label>
        <br />
        <br />
        Bienvenido al sistema de facturación SIBO SuperMarket
        <br />
        <br />
        <br />
        <asp:Button ID="butIngresarOBuscarCliente" runat="server" OnClick="butIngresarOBuscarCliente_Click1" Text="Ingresar o Buscar Cliente" />
        <br />
    </div>

</asp:Content>
