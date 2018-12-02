using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CostsManager.API.Models
{

    public class IncomeViewModel
    {

        public DateTime DateCreated { get; set; }

        public decimal  Amount { get; set; }

      
        public string Description { get; set; }

    }   
}
