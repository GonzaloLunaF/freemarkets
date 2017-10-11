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
    public partial class reporte_ventasDetalle : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idVenta = int.Parse(Request.QueryString["idVenta"]);
                cargarVentaDetalle(idVenta);               
            }
        }
        #endregion

        #region Metodos
        public DataTable cargarVentaDetalle(int idVenta)
        {
            DataTable dt = new DataTable();

            VentasDetalle_BLL ventaDetalleBLL = new VentasDetalle_BLL();
            dt = ventaDetalleBLL.cargarVentaDetalle(idVenta);

            lblNombreCliente.Text = dt.Rows[0]["nombreCliente"].ToString();
            lblCodigoCliente.Text = dt.Rows[0]["codigoCliente"].ToString();
            lblIDVenta.Text = dt.Rows[0]["idVenta"].ToString();
            lblFecha.Text = dt.Rows[0]["fechaVenta"].ToString().Substring(0, 10);
            lblNombreProducto.Text = dt.Rows[0]["nombreProducto"].ToString();
            lblTotalVenta.Text = dt.Rows[0]["totalVenta"].ToString();

            return dt;
        }
        #endregion
    }
}