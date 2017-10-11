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
    public class Ventas_BLL
    {
        public void agregarVenta(int idCliente, DateTime fechaVenta, double totalVenta)
        {
            Ventas_DAL venta = new Ventas_DAL();
            venta.agregarVenta(idCliente, fechaVenta, totalVenta);
        }

        public DataTable cargarVentaPorIDCliente(int idCliente)
        {
            Ventas_DAL venta = new Ventas_DAL();
            return venta.cargarVentaPorIDCliente(idCliente);
        }

        public DataTable cargarVenta(int idCliente)
        {
            Ventas_DAL venta = new Ventas_DAL();
            return venta.cargarVenta(idCliente);
        }
    }
}
