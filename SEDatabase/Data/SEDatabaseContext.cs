using Microsoft.EntityFrameworkCore;
using SEDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDatabase.Data
{
    public class SEDatabaseContext : DbContext 
    {
        public SEDatabaseContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-6543DI3; Database = SEDatabase; Trusted_connection=true");
        }

        DbSet<User> Users { get; set; }
        DbSet<Notification> notifications { get; set; }
        DbSet<Technique> Techniques { get; set; }
    }
}
