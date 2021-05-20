using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PenTrade.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<ApplicationUser> Representatives { get; set; }

        [Required]
        public string Adress { get; set; }
        public ICollection<CurrentStock> CurrentStock { get; set; }

        [NotMapped]
        public IEnumerable<NegotiationViewModel> Negotiations { get; set; }


    }
}
