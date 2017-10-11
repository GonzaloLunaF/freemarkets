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
    public class Existencias_BLL
    {
        public DataTable cargarExistenciasPorID(int idProducto)
        {
            Existencias_DAL existencia = new Existencias_DAL();
            return existencia.cargarExistenciasPorID(idProducto);
        }

        public void restarExistencia(int cantidad, int idProducto)
        {
            Existencias_DAL existencia = new Existencias_DAL();
            existencia.restarExistencia(cantidad, idProducto);
        }
    }
}
