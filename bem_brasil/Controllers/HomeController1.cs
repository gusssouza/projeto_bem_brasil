using Microsoft.AspNetCore.Mvc;

namespace bem_brasil.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
