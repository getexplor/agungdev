﻿using System;
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
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            this._skillService = skillService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = _skillService.GetSkill();

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
                var data = _skillService.GetById(id);

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
        public IActionResult Post(SkillViewModel skillVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }

            try
            {
                if (skillVM == null)
                {
                    return BadRequest("Data cannot null");
                }

                var data = _skillService.AddSkill(skillVM);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Put(SkillViewModel skillVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }

            try
            {
                if (skillVM == null)
                {
                    return BadRequest("Data cannot null");
                }

                var id = _skillService.GetById(skillVM.IdSkill);
                if (id == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _skillService.UpdateSkill(skillVM);

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
                var idSkill = _skillService.GetById(id);

                if (idSkill == null)
                {
                    return NotFound("Id not found !");
                }
                else
                {
                    var data = _skillService.DeleteSkill(id);

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
