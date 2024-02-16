using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GistXservices
{
    public class MyDbContext : DbContext
    {
      
        public DbSet<Gist> Gists { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Fork> Forks { get; set; }
        public DbSet<GistUser> GistUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Fork>()
                .HasRequired(f => f.User)
                .WithMany(u => u.Forks)
                .HasForeignKey(f => f.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GistUser>()
                .HasKey(gu => new { gu.GistId, gu.UserId });

            modelBuilder.Entity<GistUser>()
                .HasRequired(gu => gu.Gist)
                .WithMany(g => g.GistUsers)
                .HasForeignKey(gu => gu.GistId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GistUser>()
                .HasRequired(gu => gu.User)
                .WithMany(u => u.GistUsers)
                .HasForeignKey(gu => gu.UserId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
