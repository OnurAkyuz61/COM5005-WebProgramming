using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IKU_CARS.Models
{
    public class IKUCarDB : DbContext
    {
        public IKUCarDB() : base("IKUCarConnection")
        {
            Database.SetInitializer(new SampleData());
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
