using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlickrClone.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ImageTag>()
                .HasKey(x => new { x.ImageId, x.TagId });

            builder.Entity<ImageTag>()
                .HasOne(ic => ic.Image)
                .WithMany(i => i.ImageTags)
                .HasForeignKey(ic => ic.ImageId);

            builder.Entity<ImageTag>()
                .HasOne(ic => ic.Tag)
                .WithMany(i => i.ImageTags)
                .HasForeignKey(ic => ic.TagId);

            base.OnModelCreating(builder);
        }
    }
}
