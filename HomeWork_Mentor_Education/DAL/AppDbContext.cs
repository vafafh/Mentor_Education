using HomeWork_Mentor_Education.Models;
using Mentor_Education.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork_Mentor_Education.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Courses> Courses { get; set; }

        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PlanItem> PlanItems { get; set; }

        public DbSet<PricingPlanItem> PricingPlanItems { get; set; }


    }
}
