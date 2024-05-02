using C_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dato
{
    public class Venta_CD
    {
        public int Insertar(Venta_CE venta_CE)
        {
            int newid;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Insert into venta(fecventa,idCliente) values(@fecventa,@idCliente);";
            sql_cmd.Parameters.AddWithValue("@fecventa", venta_CE.FecVenta);
            sql_cmd.Parameters.AddWithValue("@idCliente", venta_CE.IdCliente);
            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = "select max(id) as nuevoId from venta where fecVenta=@fecVenta;";
            sql_cmd.Parameters["@fecVenta"].Value = venta_CE.FecVenta;
            SqlDataReader sql_dr = sql_cmd.ExecuteReader();
            bool fila_true = sql_dr.Read();
            if (fila_true)
            {
                newid = Convert.ToInt32(sql_dr["nuevoId"]);
            }
            else { newid = 0; }
            conexion.cerrar();
            return newid;
        }
    }
}
