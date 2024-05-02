using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class Detalle_CE
    {
        private int id;
        private int idventa;
        private string idproducto;
        private int cantidad;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdVenta
        {
            get { return idventa; }
            set { idventa = value; }
        }
        public string idProducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Detalle_CE() { }
        public Detalle_CE(int id,int idventa,string producto,int cantidad) {
            this.id = id;
            this.idventa = idventa;
            this.idproducto = producto;
            this.cantidad = cantidad;
        }

    }
}
