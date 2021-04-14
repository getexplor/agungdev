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
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            try
            {
                var data = _contactService.GetById(id);

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

        [HttpPut]
        public IActionResult Put(ContactViewModel contactVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                if (contactVM == null)
                {
                    return BadRequest("Data cannot be null");
                }

                var id = _contactService.GetById(contactVM.IdContact);
                if (id == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _contactService.UpdateContact(contactVM);

                    return Ok(data);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[Route("api/contact/")]
        [HttpPut("socialmedia")]
        public IActionResult PutSocial(ContactViewModel contactVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                if (contactVM == null)
                {
                    return BadRequest("Data cannot be null");
                }

                var id = _contactService.GetById(contactVM.IdContact);
                if (id == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _contactService.UpdateSocialMedia(contactVM);

                    return Ok(data);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
