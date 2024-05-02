using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Security.Cryptography.X509Certificates;


namespace Clases
{
    public class Conexion_clase
    {
        private string cadena = "Data Source=DESKTOP-RFS77P5;Initial Catalog=BD402;Integrated Security=True";
        private SqlConnection conexion = new SqlConnection();

        public Conexion_clase()
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
