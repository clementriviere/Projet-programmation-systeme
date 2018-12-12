using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Data.DAO;

namespace Model.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-B7ESMK7\SQLEXPRESS;Database=RestaurantDatabase; User ID=DESKTOP-B7ESMK7\ASUS; Trusted_Connection=True;ConnectRetryCount=0;", options => options.EnableRetryOnFailure());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<RecipeType> RecipeType { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Scenario> Scenario { get; set; }
        public DbSet<ScenarioPerRole> ScenarioPerRole { get; set; }
        public DbSet<ScenarioStep> ScenarioStep { get; set; }

    }
}
