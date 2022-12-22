using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiendaDelivery.App.Persistencia;
using TiendaDelivery.App.Dominio;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace TiendaDelivery.App.Frontend.Pages.Productos
{
    public class IndexModel : PageModel
    {

        private readonly IRepositorioProducto _repoProducto;
        public IEnumerable<producto> productos { get; set; }
        public string BusquedaActual { get; set; }
        public SelectList ProductoOptions { get; set; }
        public int ProductoSelected { get; set; }




        public IndexModel(IRepositorioProducto repoProducto)
        {
            _repoProducto = repoProducto;
        }

        public void OnGet()
        {
            productos = _repoProducto.GetAllProductos();
            BusquedaActual = "";


        }

        public IActionResult OnPostDelete(int id)
        {
            productos = _repoProducto.GetAllProductos();
            _repoProducto.DeleteProducto(id);
            return Page();
        }

        public void OnPostBuscar(string nombre)
        {
            ProductoOptions = new SelectList(_repoProducto.GetAllProductos(), "Id", "Nombre");
            ProductoSelected = -1;
            if (string.IsNullOrEmpty(nombre))
            {
                BusquedaActual = "";
                productos = _repoProducto.GetAllProductos();
            }
            else
            {
                BusquedaActual = nombre;
                productos = _repoProducto.SearchProductos(nombre);
            }
        }


    }
}
