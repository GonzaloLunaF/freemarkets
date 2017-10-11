using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FreeMarkets_DAL
{
    public class Productos_DAL
    {
        public DataTable buscarProductoPorCodigo(string codigo)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = @"Server=P2-C08\SQLEXPRESS;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_buscarProductoPorCodigo";

            SqlParameter param_codigo = new SqlParameter("pCodigo", codigo);
            command.Parameters.Add(param_codigo);

            conn.Open();

            da.SelectCommand = command;
            da.Fill(dt);

            conn.Close();

            return dt;

        }

        public DataTable cargarProductos()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarProductos";

            conn.Open();

            da.SelectCommand = command;
            da.Fill(dt);

            conn.Close();

            return dt;
        }
    }
}
