using Microsoft.AspNetCore.Mvc;

namespace QuickKartEmpty.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
