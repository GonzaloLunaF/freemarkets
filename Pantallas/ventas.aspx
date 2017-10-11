<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ventas.aspx.cs" Inherits="Free_Markets.Pantallas.ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<p id="demo"></p>
    <table>
        <tr>
            <td>Codigo: </td>
            <td>
                <asp:DropDownList ID="ddlCodigo" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Value="1">Flauta</asp:ListItem>
                    <asp:ListItem Value="2">Guitarra</asp:ListItem>
                </asp:DropDownList>

                <asp:RequiredFieldValidator ID="rfv_codigo" runat="server" ErrorMessage="*Debe introducir el codigo del producto." 
                ControlToValidate="ddlCodigo" InitialValue="0" Display="Dynamic" ForeColor="red" ValidationGroup="vlg1"></asp:RequiredFieldValidator> 
            </td>
        </tr>

        <tr>
            <td>Cantidad: </td>
            <td>
                <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_cantidad" runat="server" ControlToValidate="txtCantidad" ErrorMessage="*Debe introducir una cantidad."
                Display="Dynamic" ForeColor="red" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
                
                <asp:RegularExpressionValidator ID="rev_cantidad" ValidationExpression="^\d+" runat="server" ControlToValidate="txtCantidad" 
                ErrorMessage="*Debe introducir un numero entero."></asp:RegularExpressionValidator>

                <asp:RangeValidator ID="rv_cantidad" runat="server" ControlToValidate="txtCantidad" Type="Integer" MinimumValue="1" MaximumValue="99" 
                ErrorMessage="*La cantidad es invalida" Display="Dynamic" ForeColor="red" ValidationGroup="vlg1"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>Subtotal:</td>
            <td><asp:Label ID="lblSubtotal" runat="server" Text="Subtotal"></asp:Label></td>
        </tr>
        <tr>
            <td>IVA:</td>
            <td><asp:Label ID="lblIVA" runat="server" Text="IVA"></asp:Label></td>
        </tr>
        <tr>
            <td>Total Venta:</td>
            <td><asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
           <td>
               <asp:Button ID="btnAgregarVenta" runat="server" Text="Agregar" ValidationGroup="vlg1" OnClick="btnAgregarVenta_Click"/>
            </td>
        </tr>
        
    </table>
    
    <asp:GridView ID="grdVentaCliente" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:Boundfield HeaderText="Fecha" DataField="fechaVenta"/>
            <asp:Boundfield HeaderText="Codigo del Producto" DataField="codigoProducto"/>
            <asp:Boundfield HeaderText="Cantidad del Producto" DataField="cantidadProducto"/>
            <asp:Boundfield HeaderText="Total" DataField="totalVenta"/>
        </Columns>
    </asp:GridView>

    <script type= "text/javascript">
        document.getElementById("btnAgregarVenta").innerHTML = "Esta vivo!";
        document.getElementById("demo").innerHTML = 50 + 50;
        function validarCodigo(source, arguments) {
            var strings = arguments.Value;

            var numeros = 0;
            var letras = 0;
            var i = 0;
            var character = '';
            while (i <= strings.length) {
                character = strings.charAt(i);

                if (!isNaN(character * 1)) {
                    numeros++;
                }
                else if (character == character.toUpperCase()) {
                    letras++;
                }
                else if (character == character.toLowerCase()) {
                    letras++;
                }
                i++;
            }
            if (numeros == 8) {
                if (letras == 3) {
                    arguments.IsValid = true;
                }
            }
            else {
                arguments.IsValid = false;
            }

        }
    </script>


</asp:Content>
