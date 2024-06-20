using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App.Models.Data
{
    // Here is the AppDbContext class that connect the 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // this is the set entity for the Profile table used for quiring the entity 
        public DbSet<Profile> Profiles { get; private set; }

        // Configures the model and relationships using the Fluent API.
        // This method is called by the framework when the model is being created.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}