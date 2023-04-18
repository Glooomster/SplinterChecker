using System;

namespace SplinterChecker.Models
{
    public class DailyQuantity
    {
        public DateTime Date { get; set; }
        public string Username { get; set; }
        public string Type { get; set; }
        public decimal Quantity { get; set; }
    }
}
