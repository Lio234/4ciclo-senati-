using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Entidad;

namespace C_Dato
{
    public class Cliente_CD
    {
        //Metodos
        public Cliente_CE Buscarid(int id)
        {
            int m_id;
            string m_nombre;
            long m_ruc;
            string m_direccion;
            long m_tel;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql = conexion.CreateCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = "Select * From cliente where id=@id_buscar";
            sql.Parameters.AddWithValue("@id_buscar", id);
            SqlDataReader sqldr = sql.ExecuteReader();
            bool fila_true = sqldr.Read();


            if (fila_true)
            {
                m_id = Convert.ToInt32(sqldr["id"]);
                m_nombre = sqldr["nombre"].ToString();
                m_ruc = Convert.ToInt64(sqldr["numruc"]);
                m_direccion = sqldr["direccion"].ToString();
                m_tel = Convert.ToInt64(sqldr["telefono"]);
            }
            else
            {
                m_id = 0;
                m_nombre = "";
                m_ruc = 0;
                m_direccion = "";
                m_tel = 0;
            }
            conexion.cerrar();
            Cliente_CE cliente = new Cliente_CE(m_id, m_nombre, m_ruc, m_direccion, m_tel);


            return cliente;

        }

        public List<Cliente_CE> Getbuscarnombre(string buscar_nombre)
        {
            int m_id;
            string m_nombre;
            long m_ruc;
            string m_direccion;
            long m_tel;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Select * From cliente where nombre like '%'+@buscar_nombre+'%';";
            sql_cmd.Parameters.AddWithValue("@buscar_nombre", buscar_nombre);
            SqlDataReader sqldr = sql_cmd.ExecuteReader();
            List<Cliente_CE> ListCliente = new List<Cliente_CE>();

            while (sqldr.Read())
            {
                m_id = Convert.ToInt32(sqldr["id"]);
                m_nombre = sqldr["nombre"].ToString();
                m_ruc = Convert.ToInt64(sqldr["numruc"]);
                m_direccion = sqldr["direccion"].ToString();
                m_tel = Convert.ToInt64(sqldr["telefono"]);
                //Instanciar un Producto con los valores leidos
                Cliente_CE cliente = new Cliente_CE(m_id, m_nombre, m_ruc, m_direccion, m_tel);
                ListCliente.Add(cliente);
            }

            conexion.cerrar();
            return ListCliente;

        }
        public int Insertar(Cliente_CE cliente_CE)
        {
            int newid;

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Insert into cliente(nombre,numruc,direccion,telefono) values(@nombre,@ruc,@direccion,@telefono);";
            sql_cmd.Parameters.AddWithValue("@nombre", cliente_CE.Nombre);
            sql_cmd.Parameters.AddWithValue("@ruc", cliente_CE.Ruc);
            sql_cmd.Parameters.AddWithValue("@direccion", cliente_CE.Direccion);
            sql_cmd.Parameters.AddWithValue("@telefono", cliente_CE.Tel);
            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = "select max(id) as nuevoId from cliente where nombre=@nombre;";
            sql_cmd.Parameters["@nombre"].Value = cliente_CE.Nombre;
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
        public void Actualizar(Cliente_CE cliente_CE)
        {

            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "update cliente set nombre=@nombre, numruc=@ruc, direccion=@direccion, telefono=@telefono where id=@id;";
            sql_cmd.Parameters.AddWithValue("@nombre", cliente_CE.Nombre);
            sql_cmd.Parameters.AddWithValue("@ruc", cliente_CE.Ruc);
            sql_cmd.Parameters.AddWithValue("@direccion", cliente_CE.Direccion);
            sql_cmd.Parameters.AddWithValue("@telefono", cliente_CE.Tel);
            sql_cmd.Parameters.AddWithValue("@id", cliente_CE.Id);
            sql_cmd.ExecuteNonQuery();
            conexion.cerrar();
        }
        public void Eliminar(int eliminar_id)
        {
            Conexion_CD conexion = new Conexion_CD();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "delete from cliente where id=@id;";
            sql_cmd.Parameters.AddWithValue("@id", eliminar_id);
            sql_cmd.ExecuteNonQuery();
            conexion.cerrar();
        }
    }
}
