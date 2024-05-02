using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Boolean existe;
            double ld1,ld2,ld3,perimetro, area;
            String tipo;
            Triangulo triangulo = new Triangulo();
            

            ld1=triangulo.Ld1 = Convert.ToDouble(txt_ld1.Text);
            ld2=triangulo.Ld2 = Convert.ToDouble(txt_ld2.Text);
            ld3=triangulo.Ld3 = Convert.ToDouble(txt_ld3.Text);
            
            existe = triangulo.existe(ld1, ld2, ld3);
            perimetro = triangulo.perimetro(ld1, ld2, ld3, existe);
            area = triangulo.area(ld1, ld2, ld3, perimetro, existe);
            tipo = triangulo.tipo(ld1, ld2, ld3,existe);
            
            txt_existe.Text = existe.ToString();
            txt_perimetro.Text = perimetro.ToString();
            txt_area.Text = area.ToString();
            txt_tipo.Text= tipo.ToString();


        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
