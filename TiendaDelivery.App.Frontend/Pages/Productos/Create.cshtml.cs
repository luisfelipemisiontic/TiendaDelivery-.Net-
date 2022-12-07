using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiendaDelivery.App.Persistencia;
using TiendaDelivery.App.Dominio;

namespace TiendaDelivery.App.Frontend.pages.Productos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioProducto _repoProducto;
        public producto producto { get; set; }

        public CreateModel(IRepositorioProducto repoProducto)
        {
            _repoProducto = repoProducto;
        }

        public void OnGet()
        {
            producto = new producto();
        }

        public IActionResult OnPost(producto producto)
        {
            if (ModelState.IsValid){
            _repoProducto.AddProducto(producto);
            return RedirectToPage("Index");
            }
            else{
                return Page();
            }
        }


    }
}
