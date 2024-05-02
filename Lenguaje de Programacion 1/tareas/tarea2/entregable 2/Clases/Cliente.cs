using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System;
using System.Threading;

namespace Clases
{
    public class Cliente
    {
        //Variables
        private int id;
        private string nombre;
        private long ruc;
        private string direccion;
        private long tel;
        //Encapsuladores
        public int Id { 
            get { return id; } 
            set { id = value; } 
        }
        public string Nombre { 
            get {  return nombre; } 
            set {  nombre = value; } 
        }
        public long Ruc { 
            get {  return ruc; } 
            set {  ruc = value; } 
        }
        public string Direccion { 
            get { return direccion; } 
            set { direccion = value; } 
        }
        public long Tel { 
            get { return tel; } 
            set {  tel = value; } 
        }

        //Constructores
        public Cliente() { }
        public Cliente(int _id, string _nombre, long _ruc,string _direccion, long _tel)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.ruc = _ruc;
            this.direccion = _direccion;
            this .tel = _tel;
        }

        //Metodos
        public Cliente Buscarid(int id)
        {
            int m_id;
            string m_nombre;
            long m_ruc;
            string m_direccion;
            long m_tel;
         
            Conexion_clase conexion = new Conexion_clase();
            conexion.abrir();
            SqlCommand sql = conexion.CreateCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = "Select * From cliente where id=@id_buscar";
            sql.Parameters.AddWithValue("@id_buscar", id);
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            bool fila_true=sqlDataReader.Read();


            if (fila_true)
            {          
                m_id = Convert.ToInt32(sqlDataReader["id"]);
                m_nombre = sqlDataReader["nombre"].ToString();
                m_ruc = Convert.ToInt64(sqlDataReader["numruc"]);
                m_direccion = sqlDataReader["direccion"].ToString();
                m_tel = Convert.ToInt64(sqlDataReader["telefono"]);
            }
            else
            {
                m_id = 0;
                m_nombre= "";
                m_ruc = 0;
                m_direccion = "";
                m_tel= 0;
            }
            conexion.cerrar();            
            Cliente cliente = new Cliente(m_id, m_nombre, m_ruc, m_direccion, m_tel);

            
            return cliente;

        }
        
        public List<Cliente> Getbuscarnombre(string buscar_nombre) {
            int m_id;
            string m_nombre;
            long m_ruc;
            string m_direccion;
            long m_tel;

            Conexion_clase conexion = new Conexion_clase();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Select * From cliente where nombre like '%'+@nombre_buscar+'%';";
            sql_cmd.Parameters.AddWithValue("@nombre_buscar", buscar_nombre);
            SqlDataReader sqldr = sql_cmd.ExecuteReader();
            List<Cliente> ListCliente = new List<Cliente>();

            while (sqldr.Read())
            {
                m_id = Convert.ToInt32(sqldr["id"]);
                m_nombre = sqldr["nombre"].ToString();
                m_ruc = Convert.ToInt64(sqldr["numruc"]);
                m_direccion = sqldr["direccion"].ToString();
                m_tel = Convert.ToInt64(sqldr["telefono"]);
                //Instanciar un Producto con los valores leidos
                Cliente cliente = new Cliente(m_id, m_nombre, m_ruc, m_direccion, m_tel);
                ListCliente.Add(cliente);
            }

            conexion.cerrar();
            return ListCliente;

        }
        public int Insertar(Cliente cliente)
        {
            int newid;

            Conexion_clase conexion= new Conexion_clase();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "Insert into cliente(nombre,numruc,direccion,telefono) values(@nombre,@ruc,@direccion,@telefono);";
            sql_cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
            sql_cmd.Parameters.AddWithValue("@ruc", cliente.ruc);
            sql_cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
            sql_cmd.Parameters.AddWithValue("@telefono", cliente.tel);
            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText= "select max(id) as nuevoId from cliente where nombre=@nombre;";
            sql_cmd.Parameters["@nombre"].Value = cliente.nombre;         
            SqlDataReader sql_dr = sql_cmd.ExecuteReader();
            bool fila_true =sql_dr.Read();
            if (fila_true)
            {
                newid = Convert.ToInt32(sql_dr[ "nuevoId"]);
            }
            else { newid = 0; }
            conexion.cerrar();
            return newid;
        }
        public void Actualizar(Cliente cliente)
        {

            Conexion_clase conexion = new Conexion_clase();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "update cliente set nombre=@nombre, numruc=@ruc, direccion=@direccion, telefono=@telefono where id=@id;";
            sql_cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
            sql_cmd.Parameters.AddWithValue("@ruc", cliente.ruc);
            sql_cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
            sql_cmd.Parameters.AddWithValue("@telefono", cliente.tel);
            sql_cmd.Parameters.AddWithValue("@id", cliente.id);
            sql_cmd.ExecuteNonQuery();
            conexion.cerrar();
        }
        public void Eliminar(int eliminar_id)
        {
            Conexion_clase conexion = new Conexion_clase();
            conexion.abrir();
            SqlCommand sql_cmd = conexion.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;
            sql_cmd.CommandText = "DELETE FROM Cliente WHERE id=@id;";
            sql_cmd.Parameters.AddWithValue("@id", eliminar_id);
            sql_cmd.ExecuteNonQuery();
            conexion.cerrar();
        }
    }
}
