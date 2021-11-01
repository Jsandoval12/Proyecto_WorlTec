using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
   public class AreaBL
    {
        Contexto _contexto;
        public BindingList<Area> ListadeAreas { get; set; }

        public AreaBL()
        {
            _contexto = new Contexto();
            ListadeAreas = new BindingList<Area>();
        }

        public BindingList<Area>ObtenerArea()
        {
            _contexto.Area.Load();
            ListadeAreas = _contexto.Area.Local.ToBindingList();

            return ListadeAreas;
        }
    }

  

    public class Area
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
