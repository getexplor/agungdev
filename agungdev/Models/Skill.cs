using System;
using System.Collections.Generic;

#nullable disable

namespace agungdev.Models
{
    public partial class Skill
    {
        public int IdSkill { get; set; }
        public string SkillName { get; set; }
        public int? SkillValue { get; set; }
    }
}
