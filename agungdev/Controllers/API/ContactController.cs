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
                    return NotFound(data);
                }

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                if (contact == null)
                {
                    return BadRequest("Data cannot be null");
                }

                var data = _contactService.UpdateContact(contact);

                return Ok(data);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //[Route("api/contact/")]
        [HttpPut("socialmedia")]
        public IActionResult PutSocial(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                if (contact == null)
                {
                    return BadRequest("Data cannot be null");
                }

                var data = _contactService.UpdateSocialMedia(contact);

                return Ok(data);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
