using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;

namespace ReceptiKatalog
{
   /* internal class RecipeDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=recipesdb";

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        private void serverVersion(MySqlDbContextOptionsBuilder builder)
        {
            throw new NotImplementedException();
        }
    }
   */


}

