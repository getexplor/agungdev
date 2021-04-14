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
        List<SkillViewModel> ListSkillVM = new List<SkillViewModel>();
        SkillViewModel SkillVM = null;

        public SkillService(AgungDevContext context)
        {
           this._context = context;
        }

        public SkillViewModel GetById(int id)
        {
            SkillVM = _context.Skills.Where(x => x.IdSkill == id).Select(x => new SkillViewModel()
            {
                IdSkill = x.IdSkill,
                SkillName = x.SkillName,
                SkillValue = x.SkillValue
            }).FirstOrDefault<SkillViewModel>();

            return SkillVM;
        }

        public IEnumerable<SkillViewModel> GetSkill()
        {
            try
            {
                ListSkillVM = _context.Skills.Select(x => new SkillViewModel()
                {
                    IdSkill = x.IdSkill,
                    SkillName = x.SkillName,
                    SkillValue = x.SkillValue

                }).ToList<SkillViewModel>();

                return ListSkillVM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SkillViewModel UpdateSkill(SkillViewModel skillVM)
        {
            var data = _context.Skills.Where(x => x.IdSkill == skillVM.IdSkill).FirstOrDefault();

            if (data != null)
            {
                data.SkillName = skillVM.SkillName;
                data.SkillValue = skillVM.SkillValue;

                _context.SaveChanges();
            }
            return null;
        }

        public SkillViewModel AddSkill(SkillViewModel skillVM)
        {
            try
            {
                var DuplicateSkill = _context.Skills.Where(x => x.SkillName == skillVM.SkillName).FirstOrDefault();

                if (DuplicateSkill != null)
                {
                    throw new ArgumentException("Duplicate Skill");
                }
                else
                {
                    var data = _context.Add(new Skill()
                    {
                        IdSkill = skillVM.IdSkill,
                        SkillName = skillVM.SkillName,
                        SkillValue = skillVM.SkillValue
                    });

                    _context.SaveChanges();

                    return skillVM;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SkillViewModel DeleteSkill(int id)
        {
            var data = _context.Skills.Where(x => x.IdSkill == id).FirstOrDefault();

            if (data != null)
            {
                _context.Skills.Remove(data);
                _context.SaveChanges();
            }

            return null;
        }

    }

    public interface ISkillService
    {
        IEnumerable<SkillViewModel> GetSkill();
        SkillViewModel GetById(int id);
        SkillViewModel UpdateSkill(SkillViewModel skillVM);
        SkillViewModel AddSkill(SkillViewModel skillVM);
        SkillViewModel DeleteSkill(int id);
    }
}
