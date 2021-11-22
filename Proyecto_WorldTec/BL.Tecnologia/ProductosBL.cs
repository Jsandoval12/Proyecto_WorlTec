using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
   public class ProductosBL
    {
        Contexto _contexto;
        public BindingList<Producto> ListaProducto { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProducto = new BindingList<Producto>();

        }

        public BindingList<Producto> ObtenerProducto()
        {
            _contexto.Productos.Load();
            ListaProducto = _contexto.Productos.Local.ToBindingList();
            return ListaProducto;
        }

        public BindingList<Producto> ObtenerProducto(string buscar)
        {

            var resultado = _contexto.Productos.Where(r => r.Descripcion.ToLower().Contains(buscar.ToLower()));
            
            return new BindingList<Producto>(resultado.ToList());
        }
        public resultado GuardarProducto(Producto producto)
        {
            var resultado = validar(producto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges(); // Guadando los cambios en la Base de datos
            resultado.Exitoso = true;

            return resultado;
        }
        public void AgregarProducto()
        {
            var NuevoProducto = new Producto();
            _contexto.Productos.Add(NuevoProducto);

        }

        public bool EliminarProducto( int id)
        {
            foreach (var producto in ListaProducto)
            {
                if (producto.Id == id)
                {
                    ListaProducto.Remove(producto);
                    _contexto.SaveChanges();
                    return true;

                }
            }
            return false;
        }

        private resultado validar(Producto producto)
        {


            var resultado = new resultado();
            resultado.Exitoso = true;

            if (producto == null)
            {
                resultado.Mensaje = "Agruegue un producto validos";
                resultado.Exitoso = false;
                return resultado;
            }

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "No se permiten descripciones Vacias";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.Precio < 0)
            {
                resultado.Mensaje = "el precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.AreaId == 0)
            {
                resultado.Mensaje = "Seleccione el Area";
                resultado.Exitoso = false;
            }




            return resultado;
        }


        public class resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }

        public class Producto
    {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public byte[] Imagen { get; set; }
            public int AreaId { get; set; }
            public Area  Area { get; set; }
            public bool Activo { get; set; }
        }

        public void cancelarProducto()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
    }
}



