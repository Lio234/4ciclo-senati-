using C_Entidad;
using C_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Presentacion
{
    public partial class Cliente_CP : Form
    {
        private static Cliente_CP instancia = null;
        public static Cliente_CP Instancia
        {
            get
            {
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    instancia = new Cliente_CP();
                }
                return instancia;
            }
        }
        public Cliente_CP()
        {
            InitializeComponent();
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvCliente.SelectedRows[0];
                txt_cliente_id.Text = fila.Cells["id"].Value.ToString();
                txt_cliente_nombre.Text = fila.Cells["nombre"].Value.ToString();
                txt_cliente_ruc.Text = fila.Cells["ruc"].Value.ToString();
                txt_cliente_direccion.Text = fila.Cells["direccion"].Value.ToString();
                txt_cliente_tel.Text = fila.Cells["tel"].Value.ToString();

            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int idBuscado = Convert.ToInt32(txt_cliente_id.Text);

            Cliente_CN cliente_CN = new Cliente_CN();

            Cliente_CE cliente_CE= cliente_CN.Buscarid(idBuscado);


            txt_cliente_id.Text = cliente_CE.Id.ToString();
            txt_cliente_nombre.Text = cliente_CE.Nombre;
            txt_cliente_ruc.Text = cliente_CE.Ruc.ToString();
            txt_cliente_direccion.Text = cliente_CE.Direccion.ToString();
            txt_cliente_tel.Text = cliente_CE.Tel.ToString();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_cliente_id.Text = "0";
            txt_cliente_nombre.Text = "";
            txt_cliente_ruc.Text = "0";
            txt_cliente_tel.Text = "0";
            txt_cliente_direccion.Text = "";
            txt_cliente_buscar_nombre.Text = "";
            dgvCliente.DataSource = null;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cliente_CE cliente_CE = new Cliente_CE();
            //Leer los valores de las cajas de texto
            cliente_CE.Id = Convert.ToInt32(txt_cliente_id.Text);
            cliente_CE.Nombre = txt_cliente_nombre.Text;
            cliente_CE.Ruc = Convert.ToInt64(txt_cliente_ruc.Text);
            cliente_CE.Direccion = txt_cliente_direccion.Text;
            cliente_CE.Tel = Convert.ToInt64(txt_cliente_tel.Text);

            Cliente_CN cliente_CN = new Cliente_CN();

            if (txt_cliente_id.Text == "0")
            {
                //INSERTAR
                txt_cliente_id.Text = cliente_CN.Insertar(cliente_CE).ToString();
                MessageBox.Show("Cliente Registrado");
            }
            else
            {
                //ACTUALIZAR
                cliente_CN.Actualizar(cliente_CE);
                MessageBox.Show("Cliente actualizado");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_eliminar = Convert.ToInt32(txt_cliente_id.Text);
            Cliente_CN cliente = new Cliente_CN();
            cliente.Eliminar(id_eliminar);
            btn_nuevo_Click(null, null);
            MessageBox.Show("Cliente Eliminado");
        }

        private void btn_dgv_buscar_Click(object sender, EventArgs e)
        {
            string buscar_nombre = txt_cliente_buscar_nombre.Text;
            Cliente_CN cliente_CN = new Cliente_CN();
            List<Cliente_CE> listaCliente_CE = cliente_CN.Getbuscarnombre(buscar_nombre);
            dgvCliente.DataSource = listaCliente_CE;
        }

        private void Cliente_CP_Load(object sender, EventArgs e)
        {

        }
    }
}
