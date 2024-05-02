using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Dato
{
    public class Conexion_CD
    {
        public string cadena = "Data Source=DESKTOP-RFS77P5;Initial Catalog=BD402;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();

        public Conexion_CD()
        {
            conexion.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión abierta");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir BD: " + ex.Message);
            }
        }

        public void cerrar()
        {
            conexion.Close();
            Console.WriteLine("Conexión cerrada");
        }
        public SqlCommand CreateCommand()
        {
            return conexion.CreateCommand();
        }
    }
}
