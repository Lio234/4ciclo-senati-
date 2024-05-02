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
    public partial class Registro_ventas_CP : Form
    {
        public Registro_ventas_CP()
        {
            InitializeComponent();
            dgv_registroVentas.Columns.Add("col_id", "Codigo");
            dgv_registroVentas.Columns.Add("col_Descripcion", "Descripcion");
            dgv_registroVentas.Columns.Add("col_precio", "Precio x Unidad");
            dgv_registroVentas.Columns.Add("col_cantidad", "Cantidad");
            dgv_registroVentas.Columns.Add("col_subtotal", "Subtotal");
            dgv_registroVentas.AllowUserToAddRows= false;
        }
        private static Registro_ventas_CP instancia = null;
        public static Registro_ventas_CP Instancia
        {
            get
            {
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    instancia = new Registro_ventas_CP();
                }
                return instancia;
            }
        }
        private void Limpiar_cajas_venta()
        {
            txt_producto_descripcion.Text = "";
            txt_producto_id.Text= "0";
            txt_producto_precio.Text = "0";
            txt_Detalle_Cantidad.Text = "0";

        }
        private void Limpiar_cajas_total() { 
            txt_cliente_id.Text = "0";
            txt_cliente_nombre.Text = "";
            txt_producto_descripcion.Text = "";
            txt_producto_id.Text= "0";
            txt_producto_precio.Text = "0";
            txt_Detalle_Cantidad.Text = "0";
            dgv_registroVentas.Rows.Clear();
        }
        private void CalcularTotal()
        {
            double total=0.0,valor;
            foreach (DataGridViewRow fila in dgv_registroVentas.Rows) 
            {
                valor = Convert.ToDouble(fila.Cells["col_subtotal"].Value);
                total += valor;
            }
            txt_Detalle_Total.Text = total.ToString();

        }

        private void btn_cliente_buscar_Click(object sender, EventArgs e)
        {
            int cliente_idBuscado= Convert.ToInt32(txt_cliente_id.Text);
            
            Cliente_CN cliente_CN = new Cliente_CN();
            Cliente_CE cliente_CE=cliente_CN.Buscarid(cliente_idBuscado);

            txt_cliente_nombre.Text=cliente_CE.Nombre.ToString();
        }

        private void btn_producto_buscar_Click(object sender, EventArgs e)
        {
            int producto_idBuscado=Convert.ToInt32(txt_producto_id.Text);
            Producto_CN producto_CN = new Producto_CN();
            Producto_CE producto_CE = producto_CN.Buscarid(producto_idBuscado);

            txt_producto_descripcion.Text=producto_CE.Descripcion.ToString();
            txt_producto_precio.Text=producto_CE.Precio.ToString();
        }

        private void btn_detalle_Agregar_Click(object sender, EventArgs e)
        {
            int id, cantidad;
            string descripcion;
            double precioxunidad, subtotal;
            id = Convert.ToInt32(txt_producto_id.Text);
            descripcion=txt_producto_descripcion.Text;
            precioxunidad = Convert.ToDouble(txt_producto_precio.Text);
            cantidad= Convert.ToInt32(txt_Detalle_Cantidad.Text);
            subtotal = cantidad * precioxunidad;
            dgv_registroVentas.Rows.Add(id,descripcion,precioxunidad,cantidad,subtotal);
            Limpiar_cajas_venta();
            CalcularTotal();

        }

        private void btn_Cerar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_detalle_guardar_Click(object sender, EventArgs e)
        {
            int id;
            Venta_CE venta_CE = new Venta_CE();
            venta_CE.Id = 0;
            venta_CE.FecVenta = Convert.ToDateTime(txt_fecha.Text);
            venta_CE.IdCliente = Convert.ToInt32(txt_cliente_id.Text);
            
            Venta_CN venta_CN = new Venta_CN();
            id= venta_CN.Insertar(venta_CE);


            foreach (DataGridViewRow fila in dgv_registroVentas.Rows)
            {
                Detalle_CE detalle_CE = new Detalle_CE();
                detalle_CE.Id = 0;
                detalle_CE.IdVenta = id;
                detalle_CE.idProducto= fila.Cells["col_id"].Value.ToString();
                detalle_CE.Cantidad = Convert.ToInt32(fila.Cells["col_cantidad"].Value.ToString());
                
                Detalle_CN detalle_CN = new Detalle_CN();
                detalle_CN.Insertar(detalle_CE);
            }
            Limpiar_cajas_total();
            MessageBox.Show("Venta Registrada");
        }

        private void Registro_ventas_CP_Load(object sender, EventArgs e)
        {
            DateTime fecha= DateTime.Now;
            txt_fecha.Text = fecha.ToString();
        }

        private void dgv_registroVentas_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalcularTotal();
        }
    }
}
