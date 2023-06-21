using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly ProfileContext _context;

    public ProfileController(ProfileContext context)
    {
        _context = context;
    }

    // GET: api/profiles
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Profile>>> GetProfile()
    {
        return await _context.Profiles.ToListAsync();
    }

    // GET: api/profiles/5
    [HttpGet("{per_id}")]
    public async Task<ActionResult<Profile>> GeProfile(int per_id)
    {
        var profile = await _context.Profiles.FindAsync(per_id);

        if (profile == null)
        {
            return NotFound();
        }

        return profile;
    }

    // POST api/profiles
    [HttpPost]
    public async Task<ActionResult<Profile>> PostProfile(Profile profile)
    {
        _context.Profiles.Add(profile);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProfile), new { per_id = profile.per_id }, profile);
    }

    // PUT api/profiles/5
    [HttpPut("{per_id}")]
    public async Task<IActionResult> PutProfile(int per_id, Profile profile)
    {
        if (per_id != profile.per_id)
        {
            return BadRequest();
        }

        _context.Entry(profile).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE api/profiles/5
    [HttpDelete("{per_id}")]
    public async Task<IActionResult> DeletProfile(int per_id)
    {
        var profile = await _context.Profiles.FindAsync(per_id);

        if (profile == null)
        {
            return NotFound();
        }

        _context.Profiles.Remove(profile);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // dummy endpoint to test the database connection
    [HttpGet("test")]
    public string Test()
    {
        return "Hello World!";
    }
}