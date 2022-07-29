using System;
using System.Collections.Generic;

namespace StockAppDemo.Models
{
    public partial class Stock
    {
        public int Symbol { get; set; }
        public string Name { get; set; } = null!;
        public decimal? OpenPrice { get; set; }
        public decimal? ClosePrice { get; set; }
    }
}
