    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Triangulo
    {
        private double ld1;
        private double ld2;
        private double ld3;

        public double Ld1 { get; set; }
        public double Ld2 { get; set;}
        public double Ld3 { get; set;}

        public Boolean existe(double ld1, double ld2, double ld3)
        {
            if (ld1 + ld2 > ld3 && ld1 + ld3 > ld2 && ld2 + ld3 > ld1)
            {
                return true;
            }else {
                return false; 
            }
             
        }
        public double perimetro(double ld1, double ld2, double ld3, Boolean existe)
        {
            double perimetro;
            if (existe)
            {
                perimetro = ld1 + ld2 + ld3;
            }
            else {
                perimetro = 0;
            }

            return perimetro;

        }
        public double area(double ld1, double ld2, double ld3,double perimetro,Boolean existe) {
            double area, sp;
            if (existe)
            {
                sp = perimetro / 2;
                
                area = Math.Sqrt(sp * ((sp - ld1) * (sp - ld2) * (sp - ld3)));
                area=Math.Round(area, 3);
            }
            else
            {
                area = 0;
            }

            
            return area;
        }
        public String tipo(double ld1, double ld2, double ld3, Boolean existe) {
            string tipo;

            if (existe)
            {
                if (ld1 == ld2 && ld2 == ld3)
                {
                    tipo = "Equilatero";
                }
                else if (ld2 == ld3 || ld2 == ld1 || ld3 == ld1)
                {
                    tipo = "Isoseles";

                }
                else
                {
                    tipo = "Escaleno";
                }

            }
            else
            {
                tipo = "Ninguno";
            }

            
            return tipo;
        }
    }
}