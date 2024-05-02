using C_Dato;
using C_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
    public class Producto_CN
    {
        public Producto_CE Buscarid(int id)
        { 
            Producto_CD producto_CD = new Producto_CD();
            Producto_CE producto_CE= producto_CD.Buscarid(id);
            return producto_CE;

        }
        public List<Producto_CE> Getbuscardescripcion(string buscar_descripcion)
        {
            Producto_CD producto_CD= new Producto_CD();
            List<Producto_CE> ListProducto_CE = producto_CD.Getbuscardescripcion(buscar_descripcion);
            return ListProducto_CE;
        }
        public int Insertar(Producto_CE producto_CE)
        {
            int id;
            Producto_CD producto_CD=new Producto_CD();
            id=producto_CD.Insertar(producto_CE);
            return id;
        }
        public void Actualizar(Producto_CE producto_CE)
        { 
            Producto_CD producto_CD = new Producto_CD();
            producto_CD.Actualizar(producto_CE);

        }
        public void Eliminar(int eliminar_id)
        {
            Producto_CD producto_CD = new Producto_CD();
            producto_CD.Eliminar(eliminar_id);

        }



    }
}
