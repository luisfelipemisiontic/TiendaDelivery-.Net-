using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiendaDelivery.App.Persistencia;
using TiendaDelivery.App.Dominio;

namespace TiendaDelivery.App.Frontend.Pages.Productos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioProducto _repoProducto;
        public producto producto { get; set; }


        public DetailsModel(IRepositorioProducto repoProducto)
        {
            _repoProducto = repoProducto;
        }

        public IActionResult OnGet(int id)
        {
            producto = _repoProducto.GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
