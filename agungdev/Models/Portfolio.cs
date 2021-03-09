using System;
using System.Collections.Generic;

#nullable disable

namespace agungdev.Models
{
    public partial class Portfolio
    {
        public int IdPortfolio { get; set; }
        public string PortfoName { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageByte { get; set; }
        public string ImagePath { get; set; }
        public int IdCategory { get; set; }
    }
}
