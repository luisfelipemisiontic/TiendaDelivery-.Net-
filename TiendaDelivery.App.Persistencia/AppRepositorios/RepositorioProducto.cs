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

        public producto GetProducto(int idproducto)
        {
            var productoEncontrado = _appContext.Productos.Find(idproducto);
            return productoEncontrado;
        }

        public producto UpdateProducto(producto producto)
        {
            var productoEncontrado =  _appContext.Productos.Find(producto.Id);
            if (productoEncontrado != null)
            {
                productoEncontrado.imagen = producto.imagen;
                productoEncontrado.nombre = producto.nombre;
                productoEncontrado.infGeneral = producto.infGeneral;
                productoEncontrado.precio = producto.precio;
                productoEncontrado.infNutricional = producto.infNutricional;
                productoEncontrado.codInterno = producto.codInterno;
                productoEncontrado.codBarras = producto.codBarras;
                productoEncontrado.promociones = producto.promociones;
                _appContext.SaveChanges();
            }
            return productoEncontrado;
        }

        public producto DeleteProducto(int idproducto)
        {
            var productoEncontrado = _appContext.Productos.Find(idproducto);
            if (productoEncontrado != null)
            {
                _appContext.Productos.Remove(productoEncontrado);
                _appContext.SaveChanges();
            }
            return productoEncontrado;
        }

        public IEnumerable<producto> SearchProductos(string nombre)
        {
            return _appContext.Productos
            .Where(e => e.nombre.Contains(nombre));

        }


    }
}