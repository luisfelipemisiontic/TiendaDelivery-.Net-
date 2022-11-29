using TiendaDelivery.App.Dominio;
using TiendaDelivery.App.Persistencia;

namespace TiendaDelivery.App.Console
{
    class Program
    {
        private static IRepositorioProducto _repoProducto = new RepositorioProducto();
        static void Main(string[] args)
        {
            AddProducto();
        }
         
        private static void AddProducto()
        {
            var producto = new producto
            {
                imagen = "https://cdn10.totalcode.net/mercacentro/product-zoom/es/milo-actigen-rtd-tetra-180-ml-1.webp",
                nombre = "Miloliquido",
                infGeneral = "caja empaque tetrapack, 180ml, bebida lecheychocolate",
                precio = 2395,
                infNutricional = "tamaño por porcion: 1 (180ml), porcion por envase: 1, energia 130kcl, grasatotal 3grs, carbohidratos 20grs, proteina 6grs",
                codInterno = "12244188",
                codBarras = "7-702024-059561",
                promociones = "ninguna"

            };
            _repoProducto.AddProducto(producto);
        } 
    }    
}
