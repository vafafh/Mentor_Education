using Microsoft.AspNetCore.Mvc;

namespace Mentor_Education.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
