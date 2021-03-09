using System;
using System.Collections.Generic;

#nullable disable

namespace agungdev.Models
{
    public partial class About
    {
        public int IdAbout { get; set; }
        public string AboutMe { get; set; }
        public string CurrentPosition { get; set; }
        public DateTime? Birthday { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? Age { get; set; }
        public string Degree { get; set; }
    }
}
