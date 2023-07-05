using Microsoft.AspNetCore.Mvc;

namespace Saper.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
