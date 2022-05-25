namespace HomeWork_Mentor_Education.Models
{
    public class PricingPlanItem
    {
        public int Id { get; set; }
        public Pricing Pricing { get; set; }
        public PlanItem PlanItem { get; set; }

        public int PricingId { get; set; }
        public int PlanItemId { get; set; }

    }
}
