using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idBuscado = Convert.ToInt32(txt_id.Text);
            
            Cliente cliente = new Cliente();
            
            cliente = cliente.Buscarid(idBuscado);

            
            txt_id.Text = cliente.Id.ToString();
            txt_nombre.Text = cliente.Nombre;
            txt_ruc.Text= cliente.Ruc.ToString();
            txt_direccion.Text = cliente.Direccion.ToString();
            txt_tel.Text= cliente.Tel.ToString();
        }
        private void btn_dgv_buscar_Click(object sender, EventArgs e)
        {
            string buscar_nombre= txt_buscar_nombre.Text;
            Cliente cliente= new Cliente();
            List<Cliente> listaCliente = cliente.Getbuscarnombre(buscar_nombre);
            dgvCliente.DataSource = listaCliente;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_id.Text = "0";
            txt_nombre.Text = "";
            txt_ruc.Text = "0";
            txt_tel.Text= "0";
            txt_direccion.Text = "";
            txt_buscar_nombre.Text = "";
            dgvCliente.DataSource = null;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            //Leer los valores de las cajas de texto
            cliente.Id=Convert.ToInt32(txt_id.Text);
            cliente.Nombre=txt_nombre.Text;
            cliente.Ruc=Convert.ToInt64(txt_ruc.Text);
            cliente.Direccion = txt_direccion.Text;
            cliente.Tel = Convert.ToInt64(txt_tel.Text);

            if (txt_id.Text == "0")
            {
                //INSERTAR
                txt_id.Text = cliente.Insertar(cliente).ToString();
                MessageBox.Show("Cliente Registrado");
            }
            else
            {
                //ACTUALIZAR
                cliente.Actualizar(cliente);
                MessageBox.Show("Cliente actualizado");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_eliminar = Convert.ToInt32(txt_id.Text);
            Cliente cliente=new Cliente();
            cliente.Eliminar(id_eliminar);
            btn_eliminar_Click(null, null);
            MessageBox.Show("Cliente Eliminado");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
