using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using FreeMarkets_BLL;

namespace Free_Markets.Pantallas
{
    public partial class ventas : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //int idCliente = int.Parse(Request.QueryString["id"]);
                cargarProductos();
            }
        }

        protected void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(Request.QueryString["id"]);
            agregarVenta(idCliente);
            //crearTabla();
        }

        #endregion


        #region Metodos

        public void cargarPrecioProducto(string codigoProducto)
        {
            Productos_BLL productoBLL = new Productos_BLL();
            cargarPrecioProducto(ddlCodigo.SelectedValue);
        }

        public void agregarVenta(int idCliente)
        {
            DataTable dtdt = new DataTable();
            Productos_BLL productoBLL = new Productos_BLL();
            Ventas_BLL ventaBLL = new Ventas_BLL();
            VentasDetalle_BLL ventaDetalleBLL = new VentasDetalle_BLL();
            Existencias_BLL existenciasBLL = new Existencias_BLL();

            DateTime fechaVenta = DateTime.Now;
            string codigoProducto = ddlCodigo.SelectedValue;
            int cantidadProducto = int.Parse(txtCantidad.Text);
            dtdt = productoBLL.cargarProductos();
            double aux = double.Parse(dtdt.Rows[0]["precioUnitario"].ToString());
            double subtotal = (aux) * (int.Parse(txtCantidad.Text));
            double IVA = ((aux) * (int.Parse(txtCantidad.Text))) * 0.16;
            double totalVenta = subtotal + IVA;

            lblSubtotal.Text = Convert.ToString(subtotal);
            lblIVA.Text = Convert.ToString(IVA);
            lblTotal.Text = Convert.ToString(totalVenta);

            

            int idProducto = int.Parse(dtdt.Rows[0]["idProducto"].ToString());
            idProducto = ddlCodigo.SelectedIndex;

            ventaBLL.agregarVenta(idCliente, fechaVenta, totalVenta);
            dtdt = ventaBLL.cargarVenta(idCliente);
            
            int idVenta = int.Parse(dtdt.Rows[0]["idVenta"].ToString());

            ventaDetalleBLL.agregarVentaDetalle(idVenta, idProducto, cantidadProducto);
            
            ClientScript.RegisterStartupScript(this.Page.GetType(), "alerta", "alert('Venta agregada exitosamente')", true);

            existenciasBLL.restarExistencia(cantidadProducto, idProducto);

            //DataTable dt = new DataTable();
            //dt = (DataTable)ViewState["dtVentaCliente"];
            //dt.Rows.Add(fechaVenta, codigoProducto, cantidadProducto, totalVenta);
            //grdVentaCliente.DataSource = dt;
            //grdVentaCliente.DataBind();
            
        }

        public void cargarProductos()
        {
            DataTable dt = new DataTable();

            Productos_BLL productoBLL = new Productos_BLL();
            dt = productoBLL.cargarProductos();


            ddlCodigo.DataSource = dt;
            ddlCodigo.DataTextField = "nombreProducto";
            ddlCodigo.DataValueField = "idProducto";
            ddlCodigo.DataBind();

            ddlCodigo.Items.Insert(0, new ListItem("---------- Seleccione un Producto ----------", "0"));
        }

        public void crearTabla()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("fechaVenta");
            dt.Columns.Add("codigoProducto");
            dt.Columns.Add("cantidadProducto");
            dt.Columns.Add("totalVenta");

            ViewState["dtVentaCliente"] = dt;
        }

        public void limpiarCampos()
        {
            ddlCodigo.Items.Clear();
            txtCantidad.Text = "";
        }
        #endregion

        
    }
}