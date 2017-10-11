using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FreeMarkets_DAL
{
    public class Cliente_DAL
    {
        public DataTable cargarClientes()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = @"Server=GALF-HP;Database=Free Markets;Trusted_Connection=true";

            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarClientes";

            conn.Open();

            da.SelectCommand = command;
            da.Fill(dt);

            conn.Close();

            return dt;

        }
    }
}
