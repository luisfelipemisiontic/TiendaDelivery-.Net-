using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiendaDelivery.App.Persistencia;
using TiendaDelivery.App.Dominio;

namespace TiendaDelivery.App.Frontend.Pages.Productos
{
    public class IndexModel : PageModel
    {

        private readonly IRepositorioProducto _repoProducto;
        public IEnumerable<producto> productos { get; set; }

        public IndexModel(IRepositorioProducto repoProducto)
        {
            _repoProducto = repoProducto;
        }

        public void OnGet()
        {
            productos = _repoProducto.GetAllProductos();

        }
    }
}
