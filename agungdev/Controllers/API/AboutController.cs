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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = _aboutService.GetAbout();

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
                var data = _aboutService.GetById(id);

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

        [HttpPut]
        public IActionResult Put(AboutViewModel aboutVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Data Not valid");
            }

            try
            {
                if (aboutVM == null)
                {
                    return BadRequest("Data cannot null");
                }
                var data = _aboutService.Update(aboutVM);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
