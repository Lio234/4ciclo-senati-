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
    public class Detalle_CD
    {
        public int Insertar(Detalle_CE detalle_CE)
        {
            int newid;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Insert into detalle(idVenta,idProducto, cantidad) values(@idVenta,@idProducto,@cantidad);";
            sql_cmd.Parameters.AddWithValue("@idVenta", detalle_CE.IdVenta);
            sql_cmd.Parameters.AddWithValue("@idProducto", detalle_CE.idProducto);
            sql_cmd.Parameters.AddWithValue("@cantidad", detalle_CE.Cantidad);
            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = "select max(id) as nuevoId from detalle where idVenta=@idVenta;";
            sql_cmd.Parameters["@idVenta"].Value = detalle_CE.IdVenta;
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
