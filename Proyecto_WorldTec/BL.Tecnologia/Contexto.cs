using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Tecnologia.ProductosBL;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BL.Tecnologia
{
   public class Contexto : DbContext
    {
        public Contexto(): base("Venta_Tecnologica")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new Datosdeinicio());
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Area> Area { get; set; }


    }
}
