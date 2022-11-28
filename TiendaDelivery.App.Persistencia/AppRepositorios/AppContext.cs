using Microsoft.EntityFrameworkCore;
using TiendaDelivery.App.Dominio;

namespace TiendaDelivery.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<producto> Productos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataTiendaDelivery");

            }

        }

    }

}