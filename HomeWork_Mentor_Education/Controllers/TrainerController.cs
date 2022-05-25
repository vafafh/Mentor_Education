using HomeWork_Mentor_Education.DAL;
using Mentor_Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mentor_Education.Controllers
{
    public class TrainerController : Controller
    {
        private readonly AppDbContext _context;
        public TrainerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainer> trainers = _context.Trainers.Include(x => x.Position).ToList();
            return View(trainers);
        }
    }
}
