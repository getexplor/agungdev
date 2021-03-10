using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using agungdev.Models;
using Microsoft.EntityFrameworkCore;

namespace agungdev.Service
{
    public class AboutService : IAboutService
    {
        private readonly AgungDevContext _context = new AgungDevContext();
        IList<About> abt = null;
        public AboutService(AgungDevContext context)
        {
            this._context = context;
        }

        public IEnumerable<About> GetAbout()
        {
            try
            {
                abt = _context.Abouts.Select(x => new About()
                {
                    IdAbout = x.IdAbout,
                    AboutMe = x.AboutMe,
                    CurrentPosition = x.CurrentPosition,
                    City = x.City,
                    Country = x.Country,
                    Age = x.Age,
                    Birthday = x.Birthday,
                    Degree = x.Degree
                }).ToList<About>();
                return abt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public About GetById(int id)
        {
            return _context.Abouts.Where(x => x.IdAbout == id).FirstOrDefault();
        }

        public About Update(About about)
        {
            var data = _context.Abouts.Where(x => x.IdAbout == about.IdAbout).FirstOrDefault();
            if (data != null)
            {
                data.AboutMe = about.AboutMe;
                data.Age = about.Age;
                data.City = about.City;
                data.Country = about.Country;
                data.Degree = about.Degree;
                data.CurrentPosition = about.CurrentPosition;
                data.Birthday = about.Birthday;

                _context.SaveChanges();

                return data;
            }
            return null;
        }
    }

    public interface IAboutService
    {
        IEnumerable<About> GetAbout();
        About GetById(int id);
        About Update(About about);
    }

}
