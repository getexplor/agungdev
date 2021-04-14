using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agungdev.Models;

namespace agungdev.Service
{
    public class ServicesService : IServicesService
    {
        private readonly AgungDevContext _context = new AgungDevContext();
        List<ServiceViewModel> ListServiceVM = new List<ServiceViewModel>();
        ServiceViewModel serviceVM = null;

        public ServicesService(AgungDevContext context)
        {
            _context = context;
        }

        public IEnumerable<ServiceViewModel> GetServices()
        {
            try
            {
                ListServiceVM = _context.Services.Select(x => new ServiceViewModel()
                {
                    IdService = x.IdService,
                    ServiceName = x.ServiceName,
                    ServiceContent = x.ServiceContent
                }).ToList<ServiceViewModel>();

                return ListServiceVM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ServiceViewModel GetById(int id)
        {
            serviceVM = _context.Services.Where(x => x.IdService == id).Select(x => new ServiceViewModel()
            {
                IdService = x.IdService,
                ServiceName = x.ServiceName,
                ServiceContent = x.ServiceContent
            }).FirstOrDefault<ServiceViewModel>();
            return serviceVM;
        }
        public ServiceViewModel AddService(ServiceViewModel serviceVM)
        {
            var DuplicateService = _context.Services.Where(x => x.ServiceName == serviceVM.ServiceName).FirstOrDefault();
            if (DuplicateService != null)
            {

                throw new ArgumentException("Duplicate Service");
            }
            else
            {
                try
                {
                    _context.Add(new Models.Service()
                    {
                        ServiceName = serviceVM.ServiceName,
                        ServiceContent = serviceVM.ServiceContent
                    });

                    _context.SaveChanges();

                    return serviceVM;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            throw new NotImplementedException();
        }
        public ServiceViewModel UpdateService(ServiceViewModel serviceVM)
        {
            var data = _context.Services.Where(x => x.IdService == serviceVM.IdService).FirstOrDefault();
            if (data != null)
            {
                data.ServiceName = serviceVM.ServiceName;
                data.ServiceContent = serviceVM.ServiceContent;

                _context.SaveChanges();
            }
            return null;
        }
        public ServiceViewModel DeleteService(int id)
        {
            var data = _context.Services.Where(x => x.IdService == id).FirstOrDefault();

            if (data != null)
            {
                _context.Services.Remove(data);
                _context.SaveChanges();
            }
            return null;
        }
    }

    public interface IServicesService
    {
        IEnumerable<ServiceViewModel> GetServices();
        ServiceViewModel GetById(int id);
        ServiceViewModel DeleteService(int id);
        ServiceViewModel AddService(ServiceViewModel serviceVM);
        ServiceViewModel UpdateService(ServiceViewModel serviceVM);
    }
}
