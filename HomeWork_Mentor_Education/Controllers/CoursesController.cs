using HomeWork_Mentor_Education.DAL;
using HomeWork_Mentor_Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mentor_Education.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Courses> courses = _context.Courses.Include(x => x.Position).ToList();
            return View(courses);
        }
    }
}
