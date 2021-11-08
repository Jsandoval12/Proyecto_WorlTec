 using System;
using System.ComponentModel;
using System.Data.Entity;
using static BL.Tecnologia.ProductosBL;


namespace BL.Tecnologia
{
   public class FacturaBL
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

        public void AgregarFacturaDetalle(Factura factura)
        {
            if (factura != null)
            {
                var nuevoDetalle = new FacturaDetalle();
                factura.FacturaDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverFacturaDetalle(Factura factura, FacturaDetalle facturaDetalle)
        {
            if (factura != null && facturaDetalle != null )
            {
                factura.FacturaDetalle.Remove(facturaDetalle);
            }
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
            CalcularExistencia(factura);
            resultado.Exitoso = true;

            return resultado;
        }

        private void CalcularExistencia(Factura factura)
        {
            foreach (var detalle in factura.FacturaDetalle)
            {
                var producto = _contexto.Productos.Find(detalle.ProductoId);
                if (producto != null)
                {
                    if (factura.Activo == true )
                    {
                        producto.Existencia = producto.Existencia - detalle.cantidad;
                    }
                    else
                    {
                        producto.Existencia = producto.Existencia + detalle.cantidad;
                    }
                }
            }
        }

        private resultado validar(Factura factura)
        {

            var resultado = new resultado();
            resultado.Exitoso = true;

            if (factura == null)
            {
                resultado.Mensaje = "Agruegue una factura";
                resultado.Exitoso = false;

                return resultado;
            }

            if (factura.Id != 0 && factura.Activo == true)
            {
                resultado.Mensaje = "La factura ya fue emitida, no se puede realizar mas cambios";
                resultado.Exitoso = false;
            }

            if ( factura.Activo == false)
            {
                resultado.Mensaje = "La factura esta anulada";
                resultado.Exitoso = false;
            }

            if (factura.ClienteId == 0)
            {
                resultado.Mensaje = "Agruegue un CLiente";
                resultado.Exitoso = false;
            }

            if (factura.FacturaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agruegue agregue productos a la factura";
                resultado.Exitoso = false;
            }

            foreach (var detalle in factura.FacturaDetalle)
            {
                if (detalle.ProductoId == 0)
                {
                    resultado.Mensaje = "Seleccione Productos Validos";
                    resultado.Exitoso = false;
                }
            }





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

        public void CalcularFactura(Factura factura)
        {
            if (factura != null)
            {
                double subtotal = 0;

                foreach (var detalle in factura.FacturaDetalle)
                {
                    var producto = _contexto.Productos.Find(detalle.ProductoId);
                    if ( producto != null)
                    {
                        detalle.Precio = producto.Precio;
                        detalle.Total = detalle.cantidad * producto.Precio;

                        subtotal += detalle.Total;
                    }
                }

                factura.Subtotal = subtotal;
                factura.Impuesto = subtotal * 0.15;
                factura.Total = subtotal + factura.Impuesto;
            }
        }

        public bool AnularFactura(int id)
        {
            foreach (var factura in ListaFactura)
            {
                if (factura.Id == id)
                {
                    factura.Activo = false;
                    CalcularExistencia(factura);
                    _contexto.SaveChanges();

                    return true;

                }
            }
            return false;
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

    

    
}
