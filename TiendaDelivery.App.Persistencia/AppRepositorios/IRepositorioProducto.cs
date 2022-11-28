using TiendaDelivery.App.Dominio;

namespace TiendaDelivery.App.Persistencia
{
    public interface IRepositorioProducto
    {
        public producto AddProducto(producto producto);
    }
}