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
    public class Producto_CD
    {
        public Producto_CE Buscarid(int id ) 
        {
            int _id;
            string _descripcion;
            string _categoria;
            double _precio;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql = conexion.CreateCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = "Select * From producto where id=@id_buscar";
            sql.Parameters.AddWithValue("@id_buscar", id);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            bool fila_true = sqlDataReader.Read();


            if (fila_true)
            {
                _id = Convert.ToInt32(sqlDataReader["id"]);
                _descripcion = sqlDataReader["descripcion"].ToString();
                _categoria = sqlDataReader["categoria"].ToString();
                _precio = Convert.ToInt64(sqlDataReader["precio"]);
            }
            else
            {
                _id = 0;
                _descripcion = "";
                _categoria = "";
                _precio = 0;
            }
            conexion.cerrar();
            Producto_CE producto_CE = new Producto_CE(_id, _descripcion, _categoria, _precio);


            return producto_CE;
        }
        public List<Producto_CE> Getbuscardescripcion(string buscar_descripcion)
        {
            int _id;
            string _descripcion;
            string _categoria;
            double _precio;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Select * From producto where descripcion like '%'+@buscar_descripcion+'%';";
            sql_cmd.Parameters.AddWithValue("@buscar_descripcion", buscar_descripcion);
            SqlDataReader sqldr = sql_cmd.ExecuteReader();
            List<Producto_CE> ListProducto_CE = new List<Producto_CE>();

            while (sqldr.Read())
            {
                _id = Convert.ToInt32(sqldr["id"]);
                _descripcion = sqldr["descripcion"].ToString();
                _categoria = sqldr["categoria"].ToString();
                _precio = Convert.ToInt64(sqldr["precio"]);
                //Instanciar un Producto con los valores leidos
                Producto_CE producto_CE = new Producto_CE(_id,_descripcion,_categoria,_precio);    
                ListProducto_CE.Add(producto_CE);
            }

            conexion.cerrar();
            return ListProducto_CE;

        }
        public int Insertar(Producto_CE producto_CE)
        {
            int newid;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Insert into producto(descripcion,categoria,precio) values(@descripcion,@categoria,@precio);";
            sql_cmd.Parameters.AddWithValue("@descripcion", producto_CE.Descripcion);
            sql_cmd.Parameters.AddWithValue("@categoria", producto_CE.Categoria);
            sql_cmd.Parameters.AddWithValue("@precio", producto_CE.Precio);
            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = "select max(id) as nuevoId from producto where descripcion=@descripcion;";
            sql_cmd.Parameters["@descripcion"].Value = producto_CE.Descripcion;
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
        public void Actualizar(Producto_CE producto_CE)
        {

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "update producto set descripcion=@descripcion, categoria=@categoria, precio=@precio where id=@id;";
            sql_cmd.Parameters.AddWithValue("@descripcion", producto_CE.Descripcion);
            sql_cmd.Parameters.AddWithValue("@categoria", producto_CE.Categoria);
            sql_cmd.Parameters.AddWithValue("@precio", producto_CE.Precio);
            sql_cmd.ExecuteNonQuery();
            conexion.cerrar();
        }
        public void Eliminar(int eliminar_id)
        {
            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "delete from producto where id=@id;";
            sql_cmd.Parameters.AddWithValue("@id", eliminar_id);
            sql_cmd.ExecuteNonQuery();
            conexion.cerrar();
        }
    }
}
