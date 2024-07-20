using ConsoleApp29.Contants;
using ConsoleApp29.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Contexts
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers  { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.DefaultConnection);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().Property(x => x.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Teacher>().Property(x => x.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Student>().Property(x => x.IsDeleted).HasDefaultValue(false);

            modelBuilder.Entity<Group>().HasQueryFilter(x => x.IsDeleted == false);
            modelBuilder.Entity<Student>().HasQueryFilter(x => x.IsDeleted == false);
            modelBuilder.Entity<Teacher>().HasQueryFilter(x => x.IsDeleted == false);

        }
    }
}
