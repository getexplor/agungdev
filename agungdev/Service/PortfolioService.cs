using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agungdev.Models;

namespace agungdev.Service
{
    public class PortfolioService : IPortfolioService
    {
        private readonly AgungDevContext _context = new AgungDevContext();
        IList<PortfolioViewModel> ListPortfoliosVM;
        PortfolioViewModel portfolioVM = null;
        public PortfolioService(AgungDevContext context)
        {
            _context = context;
        }
        
        public PortfolioViewModel GetPortfoById(int id)
        {
            portfolioVM = _context.Portfolios.Where(x => x.IdPortfolio == id).Select(x => new PortfolioViewModel()
            {
                IdPortfolio = x.IdPortfolio,
                IdCategory = x.IdCategory,
                ImageTitle = x.ImageTitle,
                ImagePath = x.ImagePath,
                PortfoName = x.PortfoName
            }).FirstOrDefault<PortfolioViewModel>();
            return portfolioVM;
        }

        public IEnumerable<PortfolioViewModel> GetPortfolio()
        {
            try
            {
                ListPortfoliosVM = _context.Portfolios.Select(x => new PortfolioViewModel()
                {
                    IdPortfolio = x.IdPortfolio,
                    IdCategory = x.IdCategory,
                    PortfoName = x.PortfoName,
                    ImagePath = x.ImagePath,
                    ImageTitle = x.ImageTitle
                }).ToList<PortfolioViewModel>();

                return ListPortfoliosVM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PortfolioViewModel PostPortfolio(PortfolioViewModel portfolioVM)
        {
            var DuplicatePorfo = _context.Portfolios.Where(x => x.PortfoName == portfolioVM.PortfoName).FirstOrDefault();

            if (DuplicatePorfo != null)
            {
                throw new ArgumentException("Duplicate Portfolio");
            }
            else
            {
                try
                {
                    _context.Portfolios.Add(new Portfolio()
                    {
                        PortfoName = portfolioVM.PortfoName,
                        IdCategory = portfolioVM.IdCategory,
                        ImageByte = portfolioVM.ImageByte,
                        ImagePath = portfolioVM.ImagePath,
                        ImageTitle = portfolioVM.ImageTitle
                    });

                    _context.SaveChanges();

                    return portfolioVM;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }

        public PortfolioViewModel PutPortfolio(PortfolioViewModel portfolioVM)
        {
            var data = _context.Portfolios.Where(x => x.IdPortfolio == portfolioVM.IdPortfolio).FirstOrDefault();
            var DuplicatePorfo = _context.Portfolios.Where(x => x.PortfoName == portfolioVM.PortfoName).FirstOrDefault();

            if (DuplicatePorfo != null)
            {
                throw new ArgumentException("Duplicate Portfolio");
            }
            else
            {
                if (data != null)
                {
                    data.PortfoName = portfolioVM.PortfoName;
                    data.IdCategory = portfolioVM.IdCategory;

                    _context.SaveChanges();
                }
            }
            return null;
        }

        public PortfolioViewModel DeletePortfolio(int id)
        {
            var data = _context.Portfolios.Where(x => x.IdPortfolio == id).FirstOrDefault();

            if (data != null)
            {
                _context.Portfolios.Remove(data);
                _context.SaveChanges();

            }
            return null;
        }
    }

    public interface IPortfolioService
    {
        IEnumerable<PortfolioViewModel> GetPortfolio();
        PortfolioViewModel GetPortfoById(int id);
        PortfolioViewModel PostPortfolio(PortfolioViewModel portfolioVM);
        PortfolioViewModel PutPortfolio(PortfolioViewModel portfolioVM);
        PortfolioViewModel DeletePortfolio(int id);
    }
}
