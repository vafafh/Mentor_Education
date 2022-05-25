using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Mentor_Education.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
