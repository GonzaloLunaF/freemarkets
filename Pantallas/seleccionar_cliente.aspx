<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="seleccionar_cliente.aspx.cs" Inherits="Free_Markets.Pantallas.seleccionar_cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="false"
        onrowcommand="grdClientes_RowCommand">

    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton ID= "btnSeleccionar" CommandName="Seleccionar" CommandArgument='<%# Eval("idCliente") %>' runat="server" ImageUrl="~/Images/bullet.png" Height="20px" Width="20px"/>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:BoundField HeaderText="ID" DataField = "idCliente"/>
        <asp:BoundField HeaderText="Nombre" DataField = "nombreCliente"/>
        <asp:BoundField HeaderText="Codigo" DataField = "codigoCliente"/>

    </Columns>

    </asp:GridView>
</asp:Content>
