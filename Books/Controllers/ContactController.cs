using Microsoft.AspNetCore.Mvc;

namespace WebBooks.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
