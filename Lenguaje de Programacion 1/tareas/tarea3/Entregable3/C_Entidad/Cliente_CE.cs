using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidad
{
    public class Cliente_CE
    {
        //Variables
        private int id;
        private string nombre;
        private long ruc;
        private string direccion;
        private long tel;
        //Encapsuladores
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public long Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public long Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        //Constructores
        public Cliente_CE() { }
        public Cliente_CE(int _id, string _nombre, long _ruc, string _direccion, long _tel)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.ruc = _ruc;
            this.direccion = _direccion;
            this.tel = _tel;
        }

    }
}
