using Microsoft.EntityFrameworkCore;
using TiendaDelivery.App.Dominio;

namespace TiendaDelivery.App.Persistencia
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private readonly AppContext _appContext = new AppContext();

         public producto AddProducto(producto producto)
         {
            var productoInsertado = _appContext.Productos.Add(producto);
            _appContext.SaveChanges();
            return productoInsertado.Entity;
         }

         public IEnumerable<producto> GetAllProductos()
        {
            return _appContext.Productos;
        }
    }
}