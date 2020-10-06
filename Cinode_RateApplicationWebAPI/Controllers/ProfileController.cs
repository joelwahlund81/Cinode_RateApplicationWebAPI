using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinode_RateApplicationWebAPI.Models;
using Cinode_RateApplicationWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinode_RateApplicationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _repo;

        public ProfileController(IProfileRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Get one of those Profiles
        /// </summary>
        /// <param name="id">Profile id</param>
        /// <returns>A Profile with da skillz attached.</returns>
        /// <response code="200">If call was successful</response>
        /// <response code="500">If call went crappy</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProfileDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProfile(int id)
        {
            try
            {
                var profiles = await _repo.Get(id);

                return Ok(profiles);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        /// <summary>
        /// Get one of those Profiles without list of skills
        /// </summary>
        /// <param name="id">Profile id</param>
        /// <returns>A Profile.</returns>
        /// <response code="200">If call was successful</response>
        /// <response code="500">If call went crappy</response>
        [HttpGet("short/{id}")]
        [ProducesResponseType(typeof(ProfileDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProfileShort(int id)
        {
            try
            {
                var profiles = await _repo.GetWithSkills(id);

                return Ok(profiles);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        /// <summary>
        /// Get all those lovely Profiles
        /// </summary>>
        /// <returns>A list of lovely Profiles.</returns>
        /// <response code="200">If call was successful</response>
        /// <response code="500">If call went crappy</response>
        [HttpGet("all")]
        [ProducesResponseType(typeof(IEnumerable<ProfileDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProfiles()
        {
            try
            {
                var profiles = await _repo.GetProfiles();

                return Ok(profiles);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        /// <summary>
        /// Get one of those Profiles
        /// </summary>
        /// <param name="profile">A Profile Object</param>
        /// <returns>The new Profiles Id.</returns>
        /// <response code="201">If call was successful</response>
        /// <response code="500">If call went crappy</response>
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostProfile([FromBody]Profile profile)
        {
            try
            {
                var id = await _repo.Create(profile);

                return CreatedAtAction(nameof(GetProfile), new { id });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}