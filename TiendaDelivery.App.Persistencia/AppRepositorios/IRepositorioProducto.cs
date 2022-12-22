using TiendaDelivery.App.Dominio;

namespace TiendaDelivery.App.Persistencia
{
    public interface IRepositorioProducto
    {
        public producto AddProducto(producto producto);
        public IEnumerable<producto> GetAllProductos();
        public producto GetProducto(int idproducto);
        public producto UpdateProducto(producto producto);
        public producto DeleteProducto(int idproducto);
        public IEnumerable<producto> SearchProductos(string nombre);

    }

    
}