using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedoresDal()
        {
            string consulta = "select * from proveedor";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public DataTable ListarIngresoProveedoresDal()
        {
            string consulta = "SELECT TOP 1 PROVEEDOR.IDPROVEEDOR, PROVEEDOR.NOMBRE, SUM(DETALLEING.CANTIDAD) INGRESO " +
                               "FROM PRODUCTO INNER JOIN " +
                                                  "DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO INNER JOIN " +
                                                  "PROVEE ON PRODUCTO.IDPRODUCTO = PROVEE.IDPRODUCTO INNER JOIN " +
                                                  "PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN " +
                                                  "INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO AND PROVEEDOR.IDPROVEEDOR = INGRESO.IDPROVEEDOR " +
                              "GROUP BY PROVEEDOR.IDPROVEEDOR, PROVEEDOR.NOMBRE " +
                              "ORDER BY INGRESO DESC";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +
                                                         "'" + proveedor.Telefono + "'," +
                                                         "'" + proveedor.Direccion + "'," +
                                                         "'" + proveedor.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public Proveedor ObtenerProveedorId(int id)
        {
            string consulta = "select * from proveedor where idproveedor = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Proveedor proveedor = new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                proveedor.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idProveedor"]);
                proveedor.Nombre = tabla.Rows[0]["nombre"].ToString();
                proveedor.Telefono = tabla.Rows[0]["telefono"].ToString();
                proveedor.Direccion = tabla.Rows[0]["direccion"].ToString();
                proveedor.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return proveedor;
        }

        public void EditarProveedorDal(Proveedor proveedor)
        {
            string consulta = "update proveedor set nombre ='" + proveedor.Nombre + "'," +
                                                   "telefono ='" + proveedor.Telefono + "'," +
                                                   "direccion ='" + proveedor.Direccion + "'," +
                                                   "estado ='" + proveedor.Estado + "' " +
                                    "where idproveedor=" + proveedor.IdProveedor;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
