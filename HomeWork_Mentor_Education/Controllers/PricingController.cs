using HomeWork_Mentor_Education.DAL;
using HomeWork_Mentor_Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mentor_Education.Controllers
{
    public class PricingController : Controller
    {

        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Pricing> pricings = _context.Pricings.Include(x => x.pricingPlanItems).ThenInclude(x => x.PlanItem).ToList();
            return View(pricings);
        }
    }
}
