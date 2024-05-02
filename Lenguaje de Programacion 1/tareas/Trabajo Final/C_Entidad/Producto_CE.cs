using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class Producto_CE
    {
            private int id;
            private string descripcion;
            private string categoria;
            private double precio;
            
            public int Id
            {
                get
                {
                    return this.id;
                }
                set
                {
                    this.id = value;
                }
            }
            public string Descripcion
            {
                get
                {
                    return this.descripcion;
                }
                set
                {
                    this.descripcion = value;
                }
            }
            public string Categoria
            {
                get
                {
                    return this.categoria;
                }
                set
                {
                    this.categoria = value;
                }
            }
            public double Precio
            {
                get
                {
                    return this.precio;
                }
                set
                {
                    this.precio = value;
                }
            }
            //Constructores
            public Producto_CE()
            {
            }
            public Producto_CE(int _id, string _descripcion, string _categoria, double _precio)
            {
                this.id = _id;
                this.descripcion = _descripcion;
                this.categoria = _categoria;
                this.precio = _precio;
            }
        }
}
