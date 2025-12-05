using System;
using System.Data.Entity;
using System.Linq;

namespace Authentication.Models
{
    public class DbPersonel : DbContext
    {
        public DbPersonel()
            : base("name=DbPersonel")
        {
        }

        public System.Data.Entity.DbSet<Authentication.Models.User> Users { get; set; }
    }
}

