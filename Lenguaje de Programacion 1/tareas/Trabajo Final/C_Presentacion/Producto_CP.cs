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
    public partial class Producto_CP : Form
    {
        private static Producto_CP instancia=null;
        public static Producto_CP Instancia
        {
            get
            {
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    instancia = new Producto_CP();
                }
                return instancia;
            }
        }
        public Producto_CP()
        {
            InitializeComponent();
            dgvProducto.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void dgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvProducto.SelectedRows[0];
                txt_producto_id.Text = fila.Cells["id"].Value.ToString();
                txt_producto_descripcion.Text = fila.Cells["descripcion"].Value.ToString();
                txt_producto_categoria.Text = fila.Cells["categoria"].Value.ToString();
                txt_producto_precio.Text = fila.Cells["precio"].Value.ToString();
            }
        }
        private void btn_producto_buscar_Click(object sender, EventArgs e)
        {
            int idBuscado = Convert.ToInt32(txt_producto_id.Text);
            Producto_CN producto_CN = new Producto_CN();
            Producto_CE producto_CE = producto_CN.Buscarid(idBuscado);

            txt_producto_id.Text = producto_CE.Id.ToString();
            txt_producto_descripcion.Text = producto_CE.Descripcion.ToString();
            txt_producto_categoria.Text = producto_CE.Categoria.ToString();
            txt_producto_precio.Text = producto_CE.Precio.ToString();
        }
        private void btn_producto_nuevo_Click(object sender, EventArgs e)
        {
            txt_producto_id.Text = "0";
            txt_producto_descripcion.Text = "";
            txt_producto_categoria.Text = "";
            txt_producto_precio.Text = "0";
            dgvProducto.DataSource = null;
        }
        private void btn_producto_guardar_Click(object sender, EventArgs e)
        {
            Producto_CE producto_CE = new Producto_CE();
            producto_CE.Id = Convert.ToInt32(txt_producto_id.Text);
            producto_CE.Descripcion = txt_producto_descripcion.Text;
            producto_CE.Categoria = txt_producto_categoria.Text;
            producto_CE.Precio = Convert.ToDouble(txt_producto_precio.Text);

            Producto_CN producto_CN = new Producto_CN();
            if (txt_producto_id.Text == "0")
            {
                txt_producto_id.Text = producto_CN.Insertar(producto_CE).ToString();
                MessageBox.Show("Producto Registrado");
            }
            else
            {
                producto_CN.Actualizar(producto_CE);
                MessageBox.Show("Producto Actualizado");
            }
        }

        private void btn_producto_eliminar_Click(object sender, EventArgs e)
        {
            int id_eliminar=Convert.ToInt32(txt_producto_id.Text);
            Producto_CN producto_CN=new Producto_CN();
            producto_CN.Eliminar(id_eliminar);
            btn_producto_nuevo_Click(null, null);
            MessageBox.Show("Producto Eliminado");
        }
        private void btn_dgv_producto_buscar_Click(object sender, EventArgs e)
        {
            string buscar_descripcion = txt_producto_buscar_descripcion.Text;
            Producto_CN producto_CN = new Producto_CN();
            List<Producto_CE> ListProducto_CE = producto_CN.Getbuscardescripcion(buscar_descripcion);
            dgvProducto.DataSource = ListProducto_CE;

        }

    }
}
