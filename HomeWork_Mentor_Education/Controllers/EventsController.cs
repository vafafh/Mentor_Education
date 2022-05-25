using Microsoft.AspNetCore.Mvc;

namespace Mentor_Education.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
