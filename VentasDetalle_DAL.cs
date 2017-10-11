using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FreeMarkets_DAL
{
    public class VentasDetalle_DAL
    {
        public DataTable cargarVentaDetalle(int idVenta)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarVentaDetalle";

            SqlParameter param_id = new SqlParameter("pIDV", idVenta);
            command.Parameters.Add(param_id);

            conn.Open();

            da.SelectCommand = command;
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public void agregarVentaDetalle(int idVenta, int idProducto, int cantidadProducto)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_agregarVentaDetalle";

            SqlParameter param_idVenta = new SqlParameter("pIDV", idVenta);
            SqlParameter param_idProducto = new SqlParameter("pIDP", idProducto);
            SqlParameter param_cantidad = new SqlParameter("pCantidad", cantidadProducto);

            command.Parameters.Add(param_idVenta);
            command.Parameters.Add(param_idProducto);
            command.Parameters.Add(param_cantidad);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }
    }
}
