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
    public partial class seleccionar_cliente : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                grdClientes.DataSource = cargarClientes();
                grdClientes.DataBind();
            }
        }

        protected void grdClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Seleccionar")
            {
                Response.Redirect("~/Pantallas/ventas.aspx?id=" + e.CommandArgument.ToString());
            }
        }

        #endregion

        #region Metodos

        public DataTable cargarClientes()
        {
            DataTable dtClientes = new DataTable();

            Clientes_BLL clientesBLL = new Clientes_BLL();

            dtClientes = clientesBLL.cargarClientes();

            return dtClientes;

        }

        #endregion

    }
}