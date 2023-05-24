using Microsoft.AspNetCore.Mvc;

namespace BlogProjectUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
