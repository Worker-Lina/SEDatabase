using Microsoft.EntityFrameworkCore;
using SEDatabase.Models;

namespace SEDatabase.Data
{
    public class SEDatabaseContext : DbContext
    {
        public SEDatabaseContext()
        {
            Database.Migrate();
        }

        DbSet<SystemUser> SystemUsers { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Customer> Customers { get; set; } // заказчики

        DbSet<Administrator> Administrators { get; set; } // администраторы
        DbSet<Observer> Observers { get; set; } // наблюдатели
        DbSet<Notification> Notifications { get; set; } // уведомления

        DbSet<Technic> Technics { get; set; }//техника
        DbSet<Application> Applications { get; set; }//заявки
        DbSet<Executor> Executors { get; set; } // исполнители      
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-6543DI3; Database = SEDatabase; Trusted_connection=true");
        }

    }
}

