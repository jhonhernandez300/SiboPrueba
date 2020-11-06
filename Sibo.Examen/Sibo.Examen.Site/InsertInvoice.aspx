<%@ Page Title="" Language="C#" MasterPageFile="~/examen.Master" AutoEventWireup="true" CodeBehind="InsertInvoice.aspx.cs" Inherits="Sibo.Examen.Site.InsertInvoice2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 173px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            Ingresar o Buscar Factura<br />
            <br />
            ClientID
            <asp:Label ID="labCliente" runat="server" Text="0"></asp:Label>
            <br />
            AdvisorID&nbsp;
            <asp:Label ID="labAdvisorID" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            ProductID&nbsp;
            <asp:Label ID="labProductID" runat="server" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Referencia"></asp:Label>
&nbsp;
            <asp:TextBox ID="texReferencia" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;
            <asp:TextBox ID="texNombre" runat="server" Width="330px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Valor"></asp:Label>
&nbsp;
            <asp:TextBox ID="texValor" runat="server"></asp:TextBox>
            <br />
&nbsp;
            <br />
            <asp:Label ID="Label4" runat="server" Text="Descuento"></asp:Label>
&nbsp;
            <asp:TextBox ID="texDescuento" runat="server"></asp:TextBox>
&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Cantidad Disponible"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="texCantidadDisponible" runat="server"></asp:TextBox>
&nbsp;&nbsp; <asp:Label ID="Label6" runat="server" Text="Cantidad a Vender"></asp:Label>
&nbsp;
            <asp:TextBox ID="texCantidadAVender" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;
            <br />
&nbsp;
            <asp:Label ID="labMessage" runat="server" Text="_"></asp:Label>
            <br />
            <asp:Button ID="butBuscar" runat="server" Text="Buscar" OnClick="butBuscar_Click" />
            <br />
&nbsp;<br />
&nbsp;<asp:Button ID="butAgregarProducto" runat="server" Text="Agregar Producto" OnClick="butAgregarProducto_Click" />
        </div>
        <br />
        Productos Seleccionados&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<br />
    <table style="width:100%;">
        <tr>
            <td>ID</td>
            <td></td>
            <td>Nombre</td>
        </tr>
        <tr>
            <td class="auto-style1">
                
                <asp:ListBox ID="lisProductsIDs" runat="server" Width="138px"></asp:ListBox>
            </td>
            <td>&nbsp;</td>
            <td>
                
        <asp:ListBox ID="ListBox1" runat="server" Width="219px"></asp:ListBox>
            </td>
        </tr>        
    </table>
    <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Valor Total"></asp:Label>
&nbsp;
        <asp:Label ID="labValorTotal" runat="server" Text="0"></asp:Label>
        <br />
        <asp:Button ID="butIngresarVenta" runat="server" Text="Ingresar Venta" OnClick="butIngresarVenta_Click" />
</asp:Content>
