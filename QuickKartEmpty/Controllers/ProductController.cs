using Microsoft.AspNetCore.Mvc;

namespace QuickKartEmpty.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
