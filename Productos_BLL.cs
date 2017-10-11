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
    public class Productos_BLL
    {
        public DataTable buscarProductoPorCodigo(string codigo)
        {
            Productos_DAL producto = new Productos_DAL();

            DataTable dt = new DataTable();

            dt = producto.buscarProductoPorCodigo(codigo);

            if (dt.Rows.Count == 0)
            {
                throw new Exception("El producto no existe");
            }
            else
            {
                return producto.buscarProductoPorCodigo(codigo);
            }
        }

        public DataTable cargarProductos()
        {
            Productos_DAL producto = new Productos_DAL();
            return producto.cargarProductos();
        }
    }
}
