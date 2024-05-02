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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StripMenuItem_Producto_Click(object sender, EventArgs e)
        {
            Producto_CP.Instancia.MdiParent = this;
            Producto_CP.Instancia.Show();
        }

        private void StripMenuItem_Cliente_Click(object sender, EventArgs e)
        {
            Cliente_CP.Instancia.MdiParent = this;
            Cliente_CP.Instancia.Show();
        }
    }
}
