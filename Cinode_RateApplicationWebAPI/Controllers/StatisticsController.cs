using System;
using System.Collections.Generic;
using Cinode_RateApplicationWebAPI.Models;
using Cinode_RateApplicationWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinode_RateApplicationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ISkillsService _skillsService;

        public StatisticsController(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        /// <summary>
        /// Get stats over most used skill
        /// </summary>
        /// <returns>A Object full of skills.</returns>
        /// <response code="200">If call was successful</response>
        /// <response code="500">If call went crappy</response>
        [HttpGet("mostusedskill")]
        [ProducesResponseType(typeof(IEnumerable<MostUsedSkill>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult MostUsedSkill()
        {
            try
            {
                var mostUsed = _skillsService.GetMostUsedSkill();

                return Ok(mostUsed);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}