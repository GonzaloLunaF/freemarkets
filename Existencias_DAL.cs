using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FreeMarkets_DAL
{
    public class Existencias_DAL
    {
        public DataTable cargarExistenciasPorID(int idProducto)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarExistenciasPorID";

            SqlParameter param_id = new SqlParameter("pIDC", idProducto);
            command.Parameters.Add(param_id);

            conn.Open();

            da.SelectCommand = command;
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public void restarExistencia(int cantidad, int idProducto)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_restarExistencias";

            SqlParameter param_idProducto = new SqlParameter("pCantidad", cantidad);
            SqlParameter param_IDP = new SqlParameter("pIDP", idProducto);

            command.Parameters.Add(param_idProducto);
            command.Parameters.Add(param_IDP);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }
    }
}
