using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agungdev.Models;
using Microsoft.EntityFrameworkCore;

namespace agungdev.Service
{
    public class SkillService : ISkillService
    {
        private readonly AgungDevContext _context = new AgungDevContext();
        IList<Skill> skill = null;

        public SkillService(AgungDevContext context)
        {
           this._context = context;
        }

        public Skill GetById(int id)
        {
            return _context.Skills.Where(x => x.IdSkill == id).FirstOrDefault();
        }

        public IEnumerable<Skill> GetSkill()
        {
            try
            {
                skill = _context.Skills.Select(x => new Skill()
                {
                    IdSkill = x.IdSkill,
                    SkillName = x.SkillName,
                    SkillValue = x.SkillValue

                }).ToList<Skill>();

                return skill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Skill UpdateSkill(Skill skill)
        {
            var data = _context.Skills.Where(x => x.IdSkill == skill.IdSkill).FirstOrDefault();

            if (data != null)
            {
                data.SkillName = skill.SkillName;
                data.SkillValue = skill.SkillValue;

                _context.SaveChanges();

                return data;

            }
            return null;
        }

        public Skill AddSkill(Skill skill)
        {
            try
            {
               var data = _context.Add(new Skill()
               {
                   IdSkill = skill.IdSkill,
                   SkillName = skill.SkillName,
                   SkillValue = skill.SkillValue
               });

                _context.SaveChanges();

                return skill;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Skill DeleteSkill(int id)
        {
            var data = _context.Skills.Where(x => x.IdSkill == id).FirstOrDefault();

            if (data != null)
            {
                _context.Skills.Remove(data);
                _context.SaveChanges();

                return data;
            }

            return null;
        }

    }

    public interface ISkillService
    {
        IEnumerable<Skill> GetSkill();
        Skill GetById(int id);
        Skill UpdateSkill(Skill skill);
        Skill AddSkill(Skill skill);
        Skill DeleteSkill(int id);
    }
}
