using System;
using System.Collections.Generic;
using PenTrade.Models;

namespace PenTrade.ViewModels
{
    public class CompanyListView
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public IEnumerable<ApplicationUser> Representatives { get; set; }
        public IEnumerable<CurrentStock> CurrentStocks { get; set; }
        public bool HasNegotiation { get; set; }
    }
}
