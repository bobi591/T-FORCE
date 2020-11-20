using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_FORCE.Models;
using Task = T_FORCE.Models.Task;

namespace T_FORCE
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API for composite primary key in User model
            modelBuilder.Entity<User>()
                .HasKey(user => new { user.Id, user.Username, user.Email });

            //Fluent API for composite primary key in Project model
            modelBuilder.Entity<Project>()
                .HasKey(project => new { project.Id, project.Name , project.Code });
        }

        //Entities

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<KanbanBoard> KanbanBoards { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }

    /// <summary>
    /// Creates application context with concrete option settings.
    /// </summary>

    public class AppDbContextFactory : IAppDbContextFactory
    {
        public AppDbContext CreateAppDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder
                .UseSqlServer(@"Server=192.168.0.6,1433;Database=DEVTFORCE;User Id=SA;Password=Boby1998;");

            AppDbContext appDbContext = new AppDbContext(optionsBuilder.Options);



            appDbContext.Database.EnsureCreated();

            return appDbContext;
        }
    }



    public interface IAppDbContextFactory
    {
        public AppDbContext CreateAppDbContext();
    }
}
