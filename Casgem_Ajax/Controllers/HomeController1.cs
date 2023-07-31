using Microsoft.AspNetCore.Mvc;

namespace Casgem_Ajax.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
