using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace SplinterChecker.Models
{
    public class Transaction
    {
        public string Username { get; set; }
        public string Memo { get; set; }

        [JsonConverter(typeof(DecimalConverter))]
        public decimal Qty { get; set; }

        public string Type { get; set; }
        public string Timestamp { get; set; }
    }
}
