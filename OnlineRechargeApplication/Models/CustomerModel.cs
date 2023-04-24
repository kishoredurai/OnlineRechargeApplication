﻿using System.ComponentModel.DataAnnotations;

namespace OnlineRechargeApplication.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public int CustomerPhone { get; set; }

        public ServiceProviderModel ServiceProvider { get; set; }

        public int CountryCode { get; set; }

        public string CustomerAddress { get; set; }
    }
}
