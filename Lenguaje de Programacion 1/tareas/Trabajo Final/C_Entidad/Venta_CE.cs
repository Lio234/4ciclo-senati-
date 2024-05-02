using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class Venta_CE
    {
        private int id;
        private  DateTime fecventa;
        private int idCliente;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime FecVenta 
        { 
            get { return fecventa; }
            set { fecventa = value; }
        }
        public int IdCliente 
        { 
            get {  return idCliente; } 
            set {  idCliente = value; } 
        }

        public Venta_CE() { }
        public Venta_CE(int id, DateTime fecventa,int idCliente)
        {
            this.id = id;
            this.fecventa = fecventa;
            this.idCliente = idCliente;
        }

    }
}
