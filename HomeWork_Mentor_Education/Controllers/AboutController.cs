using Microsoft.AspNetCore.Mvc;

namespace Mentor_Education.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
