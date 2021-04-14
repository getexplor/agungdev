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
        List<AboutViewModel> ListAboutVM = new List<AboutViewModel>();
        AboutViewModel aboutVM = null;
        public AboutService(AgungDevContext context)
        {
            this._context = context;
        }

        public IEnumerable<AboutViewModel> GetAbout()
        {
            try
            {
                ListAboutVM = _context.Abouts.Select(x => new AboutViewModel()
                {
                    IdAbout = x.IdAbout,
                    AboutMe = x.AboutMe,
                    CurrentPosition = x.CurrentPosition,
                    City = x.City,
                    Country = x.Country,
                    Age = x.Age,
                    Birthday = x.Birthday,
                    Degree = x.Degree
                }).ToList<AboutViewModel>();
                return ListAboutVM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public AboutViewModel GetById(int id)
        {
            aboutVM = _context.Abouts.Where(x => x.IdAbout == id).Select(x => new AboutViewModel()
            {
                IdAbout = x.IdAbout,
                AboutMe = x.AboutMe,
                Age = x.Age,
                Birthday = x.Birthday,
                City = x.City,
                Country = x.Country,
                CurrentPosition = x.CurrentPosition,
                Degree = x.Degree
            }).FirstOrDefault<AboutViewModel>();
            return aboutVM;
        }

        public AboutViewModel Update(AboutViewModel aboutVM)
        {
            var data = _context.Abouts.Where(x => x.IdAbout == aboutVM.IdAbout).FirstOrDefault();
            if (data != null)
            {
                data.AboutMe = aboutVM.AboutMe;
                data.Age = aboutVM.Age;
                data.City = aboutVM.City;
                data.Country = aboutVM.Country;
                data.Degree = aboutVM.Degree;
                data.CurrentPosition = aboutVM.CurrentPosition;
                data.Birthday = aboutVM.Birthday;

                _context.SaveChanges();

            }
            return null;
        }
    }

    public interface IAboutService
    {
        IEnumerable<AboutViewModel> GetAbout();
        AboutViewModel GetById(int id);
        AboutViewModel Update(AboutViewModel aboutVM);
    }

}
