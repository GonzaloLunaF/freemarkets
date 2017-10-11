<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reporte_ventas.aspx.cs" Inherits="Free_Markets.Pantallas.reporte_ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>
                Cliente:
            </td>
            <td>
                <asp:DropDownList ID="ddlCliente" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCliente_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
    </table>

    <asp:GridView ID="grdVentas" runat="server" AutoGenerateColumns="false" OnRowCommand="grdVentas_RowCommand">

        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID= "btnDetalle" CommandName="Detalle" CommandArgument='<%# Eval("idVenta") %>' runat="server" ImageUrl="~/Images/bullet.png" Height="20px" Width="20px"/>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField HeaderText="ID" DataField="idVenta" />
            <asp:BoundField HeaderText="Fecha de la Venta" DataField="fechaVenta" />
            <asp:BoundField HeaderText="Total" DataField="totalVenta" />
        </Columns>

    </asp:GridView>



</asp:Content>
