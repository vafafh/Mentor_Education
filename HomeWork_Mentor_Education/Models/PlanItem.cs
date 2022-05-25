using System.Collections.Generic;

namespace HomeWork_Mentor_Education.Models
{
    public class PlanItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PricingPlanItem> pricingPlanItems { get; set; }
        

    }
}
