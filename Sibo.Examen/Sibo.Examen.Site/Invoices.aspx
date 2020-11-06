<%@ Page Title="" Language="C#" MasterPageFile="~/examen.Master" AutoEventWireup="true" CodeBehind="Invoices.aspx.cs" Inherits="Sibo.Examen.Site.Invoices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="InvoiceID" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar.">
    <Columns>
        <asp:BoundField DataField="InvoiceID" HeaderText="InvoiceID" ReadOnly="True" SortExpression="InvoiceID" />
        <asp:BoundField DataField="ClientID" HeaderText="ClientID" SortExpression="ClientID" />
        <asp:BoundField DataField="AdviserID" HeaderText="AdviserID" SortExpression="AdviserID" />
        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SiboSupermarket1ConnectionString2 %>" DeleteCommand="DELETE FROM [Invoice] WHERE [InvoiceID] = @InvoiceID" InsertCommand="INSERT INTO [Invoice] ([InvoiceID], [ClientID], [AdviserID], [Date]) VALUES (@InvoiceID, @ClientID, @AdviserID, @Date)" ProviderName="<%$ ConnectionStrings:SiboSupermarket1ConnectionString2.ProviderName %>" SelectCommand="SELECT [InvoiceID], [ClientID], [AdviserID], [Date] FROM [Invoice]" UpdateCommand="UPDATE [Invoice] SET [ClientID] = @ClientID, [AdviserID] = @AdviserID, [Date] = @Date WHERE [InvoiceID] = @InvoiceID">
    <DeleteParameters>
        <asp:Parameter Name="InvoiceID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="InvoiceID" Type="Int32" />
        <asp:Parameter Name="ClientID" Type="Int32" />
        <asp:Parameter Name="AdviserID" Type="Int32" />
        <asp:Parameter Name="Date" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ClientID" Type="Int32" />
        <asp:Parameter Name="AdviserID" Type="Int32" />
        <asp:Parameter Name="Date" Type="DateTime" />
        <asp:Parameter Name="InvoiceID" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
