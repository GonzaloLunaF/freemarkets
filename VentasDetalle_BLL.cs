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
    public class VentasDetalle_BLL
    {
        public DataTable cargarVentaDetalle(int idVenta)
        {
            VentasDetalle_DAL ventaDetalle = new VentasDetalle_DAL();
            return ventaDetalle.cargarVentaDetalle(idVenta);
        }

        public void agregarVentaDetalle(int idVenta, int idProducto, int cantidadProducto)
        {
            VentasDetalle_DAL ventaDetalle = new VentasDetalle_DAL();
            ventaDetalle.agregarVentaDetalle(idVenta, idProducto, cantidadProducto);
        }
    }
}
