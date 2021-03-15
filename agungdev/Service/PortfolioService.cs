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
        IList<Portfolio> portfolios;
        public PortfolioService(AgungDevContext context)
        {
            _context = context;
        }
        
        public Portfolio GetPortfoById(int id)
        {
            var data = _context.Portfolios.Where(x => x.IdPortfolio == id).FirstOrDefault();
            return data;
        }

        public IEnumerable<Portfolio> GetPortfolio()
        {
            try
            {
                portfolios = _context.Portfolios.Select(x => new Portfolio()
                {
                    IdPortfolio = x.IdPortfolio,
                    IdCategory = x.IdCategory,
                    PortfoName = x.PortfoName,
                    ImagePath = x.ImagePath,
                    ImageTitle = x.ImageTitle
                }).ToList<Portfolio>();

                return portfolios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Portfolio PostPortfolio(Portfolio portfolio)
        {
            try
            {
                var data = _context.Portfolios.Add(new Portfolio()
                {
                    PortfoName = portfolio.PortfoName,
                    IdCategory = portfolio.IdCategory,
                    ImageByte = portfolio.ImageByte,
                    ImagePath = portfolio.ImagePath,
                    ImageTitle = portfolio.ImageTitle
                });

                _context.SaveChanges();

                return portfolio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Portfolio PutPortfolio(Portfolio portfolio)
        {
            var data = _context.Portfolios.Where(x => x.IdPortfolio == portfolio.IdPortfolio).FirstOrDefault();

            if (data != null)
            {
                data.PortfoName = portfolio.PortfoName;
                data.IdCategory = portfolio.IdCategory;
                
                _context.SaveChanges();

                return data;
            }
            return null;
        }

        public Portfolio DeletePortfolio(int id)
        {
            var data = _context.Portfolios.Where(x => x.IdPortfolio == id).FirstOrDefault();

            if (data != null)
            {
                _context.Portfolios.Remove(data);
                _context.SaveChanges();

                return data;
            }
            return null;
        }
    }

    public interface IPortfolioService
    {
        IEnumerable<Portfolio> GetPortfolio();
        Portfolio GetPortfoById(int id);
        Portfolio PostPortfolio(Portfolio portfolio);
        Portfolio PutPortfolio(Portfolio portfolio);
        Portfolio DeletePortfolio(int id);
    }
}
