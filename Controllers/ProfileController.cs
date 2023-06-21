using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_crud_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ProfileContext _context;

        public ProfileController(ProfileContext context)
        {
            _context = context;
        }

        // GET api/profile
        [HttpGet]
        public ActionResult<IEnumerable<Profile>> GetProfiles()
        {
            var profiles = _context.Profiles.ToList();
            return Ok(profiles);
        }

        // GET api/profile/{id}
        [HttpGet("{id}")]
        public ActionResult<Profile> GetProfile(string id)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.PER_CODIGO == id);
            if (profile == null)
            {
                return NotFound();
            }
            return Ok(profile);
        }

        // POST api/profile
        [HttpPost]
        public ActionResult<Profile> CreateProfile(Profile profile)
        {
            profile.FECHA_CREACION = DateTime.Now;
            _context.Profiles.Add(profile);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProfile), new { id = profile.PER_CODIGO }, profile);
        }

        // PUT api/profile/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProfile(string id, Profile updatedProfile)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.PER_CODIGO == id);
            if (profile == null)
            {
                return NotFound();
            }
            profile.PER_NOMBRE = updatedProfile.PER_NOMBRE;
            profile.PER_DESCRIPCION = updatedProfile.PER_DESCRIPCION;
            profile.MODIFICADO_POR = updatedProfile.MODIFICADO_POR;
            profile.FECHA_MODIFICADO = DateTime.Now;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
