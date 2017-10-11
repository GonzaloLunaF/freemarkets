using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FreeMarkets_DAL
{
    public class Ventas_DAL
    {
        public void agregarVenta(int idCliente, DateTime fechaVenta, double totalVenta)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_agregarVenta";
            
            SqlParameter param_idCliente = new SqlParameter("pIDC", idCliente);
            SqlParameter param_fecha = new SqlParameter("pFecha", fechaVenta);
            SqlParameter param_total = new SqlParameter("pTotal", totalVenta);

            command.Parameters.Add(param_idCliente);
            command.Parameters.Add(param_fecha);
            command.Parameters.Add(param_total);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }

        public DataTable cargarVentaPorIDCliente(int idCliente)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarVentaPorIDCliente";

            SqlParameter param_id = new SqlParameter("pIDC", idCliente);
            command.Parameters.Add(param_id);

            conn.Open();

            da.SelectCommand = command;
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public DataTable cargarVenta(int idCliente)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarVenta";

            SqlParameter param_id = new SqlParameter("pIDC", idCliente);
            command.Parameters.Add(param_id);

            conn.Open();

            da.SelectCommand = command;
            da.Fill(dt);

            conn.Close();

            return dt;
        }
    }
}
