using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace FlickrClone.Models
{
    public class FlickrCloneContext : DbContext
    {
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FlickrClone;integrated security=True");
        }
    }
}
