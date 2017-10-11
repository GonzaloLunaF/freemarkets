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
    public partial class reporte_ventas : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarClientes();
            }
        }

        protected void grdVentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detalle")
            {
                Response.Redirect("~/Pantallas/reporte_ventasDetalle.aspx?idVenta=" + e.CommandArgument.ToString());
            }
        }

        protected void ddlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCliente.SelectedIndex != 0)
            {
                Ventas_BLL ventasBLL = new Ventas_BLL();
                grdVentas.DataSource = ventasBLL.cargarVentaPorIDCliente(int.Parse(ddlCliente.SelectedValue));
                grdVentas.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("idVenta");
                dt.Columns.Add("fechaVenta");
                dt.Columns.Add("totalVenta");
                grdVentas.DataSource = dt;
                grdVentas.DataBind();
            }
        }

        #endregion

        #region Metodos

        public void cargarClientes()
        {
            Clientes_BLL clienteBLL = new Clientes_BLL();

            ddlCliente.DataSource = clienteBLL.cargarClientes();
            ddlCliente.DataTextField = "nombreCliente";
            ddlCliente.DataValueField = "idCliente";
            ddlCliente.DataBind();

            ddlCliente.Items.Insert(0, "Seleccione un cliente");
        }

        #endregion

    }
}