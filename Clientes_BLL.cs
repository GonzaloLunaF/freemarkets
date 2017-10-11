using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FreeMarkets_DAL;

namespace FreeMarkets_BLL
{
    public class Clientes_BLL
    {
        public DataTable cargarClientes()
        {
            Cliente_DAL cliente = new Cliente_DAL();
            return cliente.cargarClientes();
        }

    }
}
