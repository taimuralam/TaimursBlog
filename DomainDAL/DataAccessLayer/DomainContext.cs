using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDAL.Objects;

namespace DomainDAL.DataAccessLayer
{
    public class DomainContext : DbContext
    {
        public DomainContext() : base("DefaultConnection")
        {
            
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
