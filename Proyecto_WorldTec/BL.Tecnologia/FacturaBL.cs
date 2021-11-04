using System;
using System.ComponentModel;
using System.Data.Entity;
using static BL.Tecnologia.ProductosBL;


namespace BL.Tecnologia
{
    class FacturaBL
    {
        Contexto _contexto;
        public BindingList<Factura> ListaFactura { get; set; }
       

        public FacturaBL()
        {
            _contexto = new Contexto();
            ListaFactura = new BindingList<Factura>();

        }

        public BindingList<Factura> ObtenerFacturas()
        {
            _contexto.Factura.Include("FacturaDetalle").Load();
            ListaFactura = _contexto.Factura.Local.ToBindingList();
            return ListaFactura;
        }

        public void AgregarFactura()
        {
            var nuevaFactura = new Factura();
            _contexto.Factura.Add(nuevaFactura);

        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public resultado GuardarFactura(Factura factura)
        {
            var resultado = validar(factura);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges(); // Guadando los cambios en la Base de datos
            resultado.Exitoso = true;

            return resultado;
        }


        private resultado validar(Factura factura)
        {

            var resultado = new resultado();
            resultado.Exitoso = true;

            //if (string.IsNullOrEmpty(factura.Descripcion) == true)
            //{
            //    resultado.Mensaje = "No se permiten descripciones Vacias";
            //    resultado.Exitoso = false;
            //}

            //if (producto.Existencia < 0)
            //{
            //    resultado.Mensaje = "La existencia debe ser mayor que cero";
            //    resultado.Exitoso = false;
            //}

            //if (producto.Precio < 0)
            //{
            //    resultado.Mensaje = "el precio debe ser mayor que cero";
            //    resultado.Exitoso = false;
            //}

            //if (producto.AreaId == 0)
            //{
            //    resultado.Mensaje = "Seleccione el Area";
            //    resultado.Exitoso = false;
            //}




            return resultado;
        }

    }

    

    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            FacturaDetalle = new BindingList<FacturaDetalle>();
            Activo = true;
        }

    }

    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public FacturaDetalle()
        {
            cantidad = 1;

        }

    }

    

    //public class Cliente
    //{
    //}
}
