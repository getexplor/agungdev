using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agungdev.Models;
using agungdev.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace agungdev.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = _portfolioService.GetPortfolio();

                if (data == null)
                {
                    return NotFound();
                }
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
                var data = _portfolioService.GetPortfoById(id);

                if (data == null)
                {
                    return NotFound("data dengan id " + id + " tidak ditemukan !!");
                }

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
        [HttpPost]
        public IActionResult Post(PortfolioViewModel portfolioVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                if (portfolioVM == null)
                {
                    return BadRequest("Data cannot null");
                }

                var data = _portfolioService.PostPortfolio(portfolioVM);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            
        }
        [HttpPut]
        public IActionResult Put(PortfolioViewModel portfolioVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid data");
            }

            try
            {
                var id = _portfolioService.GetPortfoById(portfolioVM.IdPortfolio);
                if (id == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _portfolioService.PutPortfolio(portfolioVM);
                    return Ok(data);
                }
            } catch (Exception ex)
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
                var idPortfo = _portfolioService.GetPortfoById(id);

                if (idPortfo == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _portfolioService.DeletePortfolio(id);
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
