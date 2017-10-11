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
    public partial class existencias : System.Web.UI.Page
    {
              #region Eventos
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarProductos();
            }
        }

        protected void ddlProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProducto.SelectedIndex != 0)
            {

                Existencias_BLL existenciasBLL = new Existencias_BLL();
                grdProductos.DataSource = existenciasBLL.cargarExistenciasPorID(int.Parse(ddlProducto.SelectedValue));
                grdProductos.DataBind();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("codigoProducto");
                dt.Columns.Add("nombreProducto");
                dt.Columns.Add("cantidad");
                grdProductos.DataSource = dt;
                grdProductos.DataBind();
            }
        }

        protected void grdProductos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int cantidad = (int)DataBinder.Eval(e.Row.DataItem, "cantidadExistencia");
                if (cantidad > 5)
                {
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.Color.GreenYellow;
                    e.Row.Font.Bold = true;
                }
                else if (cantidad > 2 && cantidad < 5)
                {
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.Color.LightYellow;
                    e.Row.Font.Bold = true;
                }
                else
                {
                    e.Row.ForeColor = System.Drawing.Color.Black;
                    e.Row.BackColor = System.Drawing.Color.Red;
                    e.Row.Font.Bold = true;
                }
            }
        }

        #endregion

        #region Metodos

        public void cargarProductos()
        {
            Productos_BLL productoBLL = new Productos_BLL();

            ddlProducto.DataSource = productoBLL.cargarProductos();
            ddlProducto.DataTextField = "nombreProducto";
            ddlProducto.DataValueField = "idProducto";
            ddlProducto.DataBind();

            ddlProducto.Items.Insert(0, "Seleccione un producto");
        }

        #endregion
        
    }
}