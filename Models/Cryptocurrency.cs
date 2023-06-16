using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP.Website.Models
{
    public class Cryptocurrency
    {
        public short Rank { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Abbreviation { get; set; }
        public string USDValuation { get; set; } = string.Empty;
        public string MarketCap { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
