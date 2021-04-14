using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using agungdev.Models;
using agungdev.Service;
using Newtonsoft.Json;

namespace agungdev.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        [HttpGet]
        public IActionResult GetService()
        {
            try
            {
                var data = _servicesService.GetServices();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var data = _servicesService.GetById(id);

                if (data == null)
                {
                    return NotFound("Id not found !");
                }

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost]
        public IActionResult Post(ServiceViewModel serviceVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Data Not Valid");
            }

            try
            {
                if (serviceVM == null)
                {
                    return BadRequest("Data cannot null");
                }
                var data = _servicesService.AddService(serviceVM);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
        [HttpPut]
        public IActionResult Put(ServiceViewModel serviceVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Data Not Valid");
            }

            try
            {
                if (serviceVM == null)
                {
                    return BadRequest("Data cannot null");
                }

                var id = _servicesService.GetById(serviceVM.IdService);

                if (id == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _servicesService.UpdateService(serviceVM);
                    return Ok(data);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound(id);
            }

            try
            {
                var idservice = _servicesService.GetById(id);
                if (idservice == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _servicesService.DeleteService(id);

                    return Ok("Success Delete Data : " + id);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
