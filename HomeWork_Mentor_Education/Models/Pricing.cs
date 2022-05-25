using System.Collections.Generic;

namespace HomeWork_Mentor_Education.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public List<PricingPlanItem> pricingPlanItems { get; set; }
    }
}
