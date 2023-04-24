using System.ComponentModel.DataAnnotations;

namespace OnlineRechargeApplication.Models
{
    public class PlanModel
    {
        [Key]
        public int planId {  get; set; }

        public string planName { get; set; }

        public int planPrice { get; set; }

        public int planValidity { get; set; }

        public ServiceProviderModel ServiceProvider { get; set; }

    }
}
