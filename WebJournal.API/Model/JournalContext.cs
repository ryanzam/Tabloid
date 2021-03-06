using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebJournal.Model
{
    public class JournalContext : DbContext
    {
        public JournalContext(DbContextOptions<JournalContext> opt) : base(opt)
        {
            
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoriesPost> CategoriesPost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
               .Property(p => p.CreatedOn)
               .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Category>()
                .Property(c => c.CreatedOn)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Comment>()
                .Property(c => c.CreatedOn)
                .HasDefaultValueSql("getdate()");
        }
    }
}
