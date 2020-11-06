<%@ Page Title="" Language="C#" MasterPageFile="~/examen.Master" AutoEventWireup="true" CodeBehind="ManageClient.aspx.cs" Inherits="Sibo.Examen.Site.ManageClient2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Ingresar o Buscar Cliente</h2>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Cedula"></asp:Label>
&nbsp;
            <asp:TextBox ID="texCedula" runat="server"></asp:TextBox>
    <br />Nombres
            <asp:TextBox ID="texNombres" runat="server"></asp:TextBox>
    <br />Apellidos&nbsp;
            <asp:TextBox ID="texApellidos" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="labMessage" runat="server" Text="_"></asp:Label>
    <br />
<asp:Label ID="Label2" runat="server" Text="ClientID"></asp:Label>
&nbsp;&nbsp;
<asp:Label ID="labClientID" runat="server" Text="0"></asp:Label>
<br />
AdviserID&nbsp;
<asp:Label ID="labAdviserID" runat="server" Text="0"></asp:Label>
<br />
    <br />
    <asp:Button ID="butConsultar" runat="server" OnClick="Consultar" Text="Consultar" />
    <br />
<br />
<asp:Button ID="butConsultarConServicio" runat="server" OnClick="butConsultarConServicio_Click" Text="Consultar Con Servicio" />
    <br />
&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:Button ID="butIngresarCliente" runat="server" Text="Ingresar Cliente" OnClick="butIngresar_Click" />
    <br />
<br />
<asp:Button ID="butIngresarClienteConServicio" runat="server" OnClick="butIngresarClienteConServicio_Click" Text="Ingresar Cliente Con Servicio" />
    <br />
<br />
<asp:Button ID="butIngresarCompra" runat="server" Enabled="False" OnClick="butIngresarCompra_Click" Text="Ingresar Compra" />
    <br />
    <br />
    <asp:Button ID="butIngresarCompraConProcedimiento" runat="server" OnClick="butIngresarCompraConProcedimiento_Click" Text="Ingresar Compra Con Procedimiento Almacenado" />
    <br />
</asp:Content>
