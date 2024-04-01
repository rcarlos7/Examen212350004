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
    public class DetalleVentaDal
    {
        public DataTable ListarDetallesVentaDal()
        {
            string consulta = "SELECT TOP 1 MARCA.IDMARCA, MARCA.NOMBRE, SUM(DETALLEVENTA.CANTIDAD) AS CANTIDAD_VENDIDA " +
                              "FROM DETALLEVENTA INNER JOIN " +
                                                  "PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN " +
                                                  "MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA " +
                              "GROUP BY MARCA.IDMARCA, MARCA.NOMBRE " +
                              "ORDER BY CANTIDAD_VENDIDA DESC ";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public DataTable ListarProductosVendidosXVendedorDal()
        {
            string consulta = "SELECT PERSONA.NOMBRE + ' ' + PERSONA.APELLIDO AS NOMBRE_COMPLETO, USUARIOROL.IDROL, PRODUCTO.NOMBRE AS PRODUCTO, SUM(DETALLEVENTA.CANTIDAD) AS CANTIDAD_VENDIDA " +
                              "FROM USUARIOROL INNER JOIN " +
                                                  "USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN " +
                                                  "VENTA ON USUARIO.IDUSUARIO = VENTA.IDVENDEDOR INNER JOIN " +
                                                  "DETALLEVENTA ON VENTA.IDVENTA = DETALLEVENTA.IDVENTA INNER JOIN " +
                                                  "PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN " +
                                                  "ROL ON USUARIOROL.IDROL = ROL.IDROL INNER JOIN " +
                                                  "PERSONA ON USUARIO.IDPERSONA = PERSONA.IDPERSONA " +
                               "WHERE USUARIOROL.IDROL = 4 " +
                               "GROUP BY PERSONA.NOMBRE + ' ' + PERSONA.APELLIDO, USUARIOROL.IDROL, PRODUCTO.NOMBRE";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleVenta values(" + detalleVenta.IdVenta + "," +
                                                               "" + detalleVenta.IdProducto + "," +
                                                               "" + detalleVenta.Cantidad + "," +
                                                               "" + detalleVenta.PrecioVenta + "," +
                                                               "" + detalleVenta.SubTotal + "," +
                                                               "'" + detalleVenta.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta detalleVenta = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                detalleVenta.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["idDetalleVenta"]);
                detalleVenta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                detalleVenta.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                detalleVenta.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleVenta.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioVenta"].ToString());
                detalleVenta.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subTotal"].ToString());
                detalleVenta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleVenta;
        }

        public void EditarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "update detalleventa set idVenta =" + detalleVenta.IdVenta + "," +
                                                      "idProducto =" + detalleVenta.IdProducto + "," +
                                                      "cantidad =" + detalleVenta.Cantidad + "," +
                                                      "precioVenta =" + detalleVenta.PrecioVenta + "," +
                                                      "subtotal =" + detalleVenta.SubTotal + "," +
                                                      "estado ='" + detalleVenta.Estado + "' " +
                                    "where iddetalleventa =" + detalleVenta.IdDetalleVenta;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
