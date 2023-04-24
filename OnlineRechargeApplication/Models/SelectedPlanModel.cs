using System.ComponentModel.DataAnnotations;

namespace OnlineRechargeApplication.Models
{
    public class SelectedPlanModel
    {
        [Key]
        public int SelectedPlanId { get; set; }

        public PlanModel Plan { get; set; }

        public CustomerModel Customer { get; set; }

        public DateTime Created { get; set; }
    }
}
