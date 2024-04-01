﻿using SistemasVentas.Modelos;
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
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "SELECT TIPOPROD.IDTIPOPROD, TIPOPROD.NOMBRE, SUM(DETALLEVENTA.CANTIDAD) AS CANTIDAD_VENDIDA " +
                               " FROM PRODUCTO INNER JOIN " +
                                              " DETALLEVENTA ON PRODUCTO.IDPRODUCTO = DETALLEVENTA.IDPRODUCTO INNER JOIN "  +
                                               "TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD " +
                                "GROUP BY TIPOPROD.IDTIPOPROD, TIPOPROD.NOMBRE"; 

            return Conexion.EjecutarDataTabla(consulta, "Consulta");
        }

        public void InsertarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "insert into tipoProd values('" + tipoProd.Nombre + "'," +
                                                          "'" + tipoProd.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public TipoProd ObtenerTipoProdId(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            TipoProd tipoProd = new TipoProd();
            if (tabla.Rows.Count > 0)
            {
                tipoProd.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idTipoProd"]);
                tipoProd.Nombre = tabla.Rows[0]["nombre"].ToString();
                tipoProd.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return tipoProd;
        }

        public void EditarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "update tipoprod set nombre ='" + tipoProd.Nombre + "'," +
                                                 "estado ='" + tipoProd.Estado + "' " +
                                    "where idtipoprod =" + tipoProd.IdTipoProd;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
