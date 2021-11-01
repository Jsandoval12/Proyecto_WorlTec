using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class Datosdeinicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var area1 = new Area();
            area1.Descripcion = "Oficina";
            contexto.Area.Add(area1);

            var area2 = new Area();
            area2.Descripcion = "Computadoras";
            contexto.Area.Add(area2);

            var area3 = new Area();
            area3.Descripcion = "Herramientas";
            contexto.Area.Add(area3);

            var area4 = new Area();
            area4.Descripcion = "Repuestos";
            contexto.Area.Add(area4);

            var area5 = new Area();
            area5.Descripcion = "Audio y Video";
            contexto.Area.Add(area5);

            var area6 = new Area();
            area6.Descripcion = "Monitores";
            contexto.Area.Add(area6);

            var area7 = new Area();
            area7.Descripcion = "Impresoras";
            contexto.Area.Add(area7);

            var area8 = new Area();
            area8.Descripcion = "Accesorios";
            contexto.Area.Add(area8);

            var area9 = new Area();
            area9.Descripcion = "Celulares";
            contexto.Area.Add(area9);

            var area10 = new Area();
            area10.Descripcion = "Novedades";
            contexto.Area.Add(area10);


            base.Seed(contexto);
        }
    }

}
