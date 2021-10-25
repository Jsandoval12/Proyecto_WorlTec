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
        Contexto _contexto; // declaracion de la variable
        public BindingList<Producto> ListaProducto { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto(); // inicializacion de la variable
            ListaProducto = new BindingList<Producto>();

        }

        public BindingList<Producto> ObtenerProducto()
        {
            _contexto.Productos.Load(); 
            ListaProducto = _contexto.Productos.Local.ToBindingList();
            return ListaProducto;
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
            ListaProducto.Add(NuevoProducto);

        }

        public bool EliminarProducto( int id)
        {
            foreach (var producto in ListaProducto)
            {
                if (producto.Id == id)
                {
                    ListaProducto.Remove(producto);
                    _contexto.SaveChanges(); // guardar lo cambios en la base de datos
                    return true;

                }
            }
            return false;
        }

        private resultado validar(Producto producto)
        {

            var resultado = new resultado();
            resultado.Exitoso = true;

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
            public bool Activo { get; set; }
        }

        
    }
}



