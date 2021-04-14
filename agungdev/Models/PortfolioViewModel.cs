using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agungdev.Models
{
    public class PortfolioViewModel
    {
        public int IdPortfolio { get; set; }
        public string PortfoName { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageByte { get; set; }
        public string ImagePath { get; set; }
        public int IdCategory { get; set; }
    }
}
