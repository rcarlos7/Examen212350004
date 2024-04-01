﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetallesIngDal()
        {
            string consulta = "SELECT DETALLEING.IDDETALLEING, PROVEEDOR.NOMBRE AS PROVEEDOR, PRODUCTO.NOMBRE AS PRODUCTO, DETALLEING.FECHAVENC, " +
                                     "DETALLEING.CANTIDAD, DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL, DETALLEING.ESTADO " +
                               "FROM DETALLEING INNER JOIN " +
                                                  "INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO INNER JOIN " +
                                                  "PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN " +
                                                  "PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO";

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public void InsertarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "insert into detalleIng values(" + detalleIng.IdIngreso + "," +
                                                         "" + detalleIng.IdProducto + "," +
                                                         "'" + detalleIng.FechaVenc + "'," +
                                                         "" + detalleIng.Cantidad + "," +
                                                         "" + detalleIng.PrecioCosto + "," +
                                                         "" + detalleIng.PrecioVenta + "," +
                                                         "" + detalleIng.SubTotal + "," +
                                                         "'" + detalleIng.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public DetalleIng ObtenerDetalleIngId(int id)
        {
            string consulta = "select * from detalleing where iddetalleing = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleIng detalleIng = new DetalleIng();
            if (tabla.Rows.Count > 0)
            {
                detalleIng.IdDetalleIng = Convert.ToInt32(tabla.Rows[0]["idDetalleIng"]);
                detalleIng.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idIngreso"]);
                detalleIng.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                detalleIng.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechaVenc"]);
                detalleIng.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleIng.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["precioCosto"]);
                detalleIng.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioVenta"]);
                detalleIng.SubTotal = Convert.ToDecimal(tabla.Rows[0]["SubTotal"]);
                detalleIng.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleIng;
        }

        public void EditarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "update detalleing set idIngreso =" + detalleIng.IdIngreso + "," +
                                                    "idProducto =" + detalleIng.IdProducto + "," +
                                                    "fechaVenc ='" + detalleIng.FechaVenc + "'," +
                                                    "cantidad =" + detalleIng.Cantidad + "," +
                                                    "precioCosto =" + detalleIng.PrecioCosto + "," +
                                                    "precioVenta =" + detalleIng.PrecioVenta + "," +
                                                    "subTotal =" + detalleIng.SubTotal + "," +
                                                    "estado='" + detalleIng.Estado + "' " +
                                    "where idDetalleIng=" + detalleIng.IdDetalleIng;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleIngDal(int id)
        {
            string consulta = "delete from detalleing where iddetalleing =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
