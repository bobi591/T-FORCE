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

        /// <summary>
        /// Sets the model properties before at startup.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API for Composite Primary Key in User model
            modelBuilder.Entity<User>()
                .HasKey(user => new { user.Id, user.Username, user.Email });

            //Fluent API for Composite Primary Key in Project model
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
    /// AppDBContect factory implementing by the IAppDbContextFactory inteface.
    /// </summary>
    public class AppDbContextFactory : IAppDbContextFactory
    {
        /// <summary>
        /// Creates application context with concrete option settings.
        /// </summary>
        public AppDbContext CreateAppDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TFORCE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            AppDbContext appDbContext = new AppDbContext(optionsBuilder.Options);



            appDbContext.Database.EnsureCreated();

            return appDbContext;
        }
    }


    /// <summary>
    /// Factory interface for accessing db context in other classes.
    /// </summary>
    public interface IAppDbContextFactory
    {
        public AppDbContext CreateAppDbContext();
    }
}
