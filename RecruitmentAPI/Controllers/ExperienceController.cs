﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecruitmentAPI.Models;
using RecruitmentAPI.Repository;

namespace RecruitmentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : ControllerBase
    {
        private IFactoryMaster _repo;
        public ExperienceController(IFactoryMaster repo)
        {
            _repo = FactoryMaster.GetFactoryObj("experience"); //repo;
        }

        [HttpGet]
        public CommonResponseModel Get()
        {
            CommonResponseModel _objResp = new CommonResponseModel();

            var result = _repo.GetDetails();
            _objResp.Data = result;

            if (result != null)
            {
                _objResp.Count = result.Count;
            }
            else
            {
                _objResp.Count = 0;
            }
            return _objResp;
        }

        [HttpPost]
        public IActionResult Post([FromBody] SkillsMaster req)
        {
            bool result = _repo.Save(req);
            if (result)
                return Ok("Success");

            return Ok("Fail");
        }

        [HttpPut]
        public IActionResult Put([FromBody] SkillsMaster req)
        {
            bool result = _repo.Update(req);
            if (result)
                return Ok("Success");

            return Ok("Fail");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            bool result = _repo.Remove(id);
            if (result)
                return Ok("Success");

            return Ok("Fail");
        }
    }
}
