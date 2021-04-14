using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agungdev.Models
{
    public class UserViewModel
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageByte { get; set; }
        public string ImagePath { get; set; }
        public int IdRole { get; set; }
        public string Name { get; set; }
    }
}
