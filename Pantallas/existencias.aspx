<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="existencias.aspx.cs" Inherits="Free_Markets.Pantallas.existencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>

        <tr>
            <td>
                Producto:
            </td>
            <td>
                <asp:DropDownList ID="ddlProducto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProducto_SelectedIndexChanged" ></asp:DropDownList>
            </td>
        </tr>

    </table>

    <asp:GridView ID="grdProductos" runat="server" AutoGenerateColumns="false" OnRowDataBound="grdProductos_RowDataBound" >

        <Columns>
            <asp:BoundField HeaderText="Codigo del Producto" DataField="codigoProducto" />
            <asp:HyperLinkField runat="server" DataNavigateUrlFields="codigoProducto" DataNavigateUrlFormatString="/About.aspx?codigo={0}" DataTextField="codigoProducto" HeaderText="Codigo del Producto1" ItemStyle-Width="100px" ItemStyle-Wrap="true"/>
            <asp:BoundField HeaderText="Nombre del Producto" DataField="nombreProducto" />
            <asp:BoundField HeaderText="Existencia" DataField="cantidadExistencia" />
        </Columns>

    </asp:GridView>
    

</asp:Content>
