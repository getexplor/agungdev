using System;
using System.Collections.Generic;

#nullable disable

namespace agungdev.Models
{
    public partial class Contact
    {
        public int IdContact { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
    }
}
