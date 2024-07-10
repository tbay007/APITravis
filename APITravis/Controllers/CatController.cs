using Microsoft.AspNetCore.Mvc;

namespace APITravis.Controllers
{
    public class CatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
