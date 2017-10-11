<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reporte_ventasDetalle.aspx.cs" Inherits="Free_Markets.Pantallas.reporte_ventasDetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>Nombre del Cliente </td>
            <td>
                <asp:Label ID="lblNombreCliente" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>Codigo del Cliente: </td>
            <td>
                <asp:Label ID="lblCodigoCliente" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>ID de la Venta: </td>
            <td>
                <asp:Label ID="lblIDVenta" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>Fecha de la Venta: </td>
            <td>
                <asp:Label ID="lblFecha" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>Nombre del Producto </td>
            <td>
                <asp:Label ID="lblNombreProducto" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td>Total de la Venta: </td>
            <td>
                <asp:Label ID="lblTotalVenta" runat="server"></asp:Label>
            </td>
        </tr>
</table>


</asp:Content>
