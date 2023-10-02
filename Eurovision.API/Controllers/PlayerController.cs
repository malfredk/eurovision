using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eurovision.API;
using Eurovision.API.Data;
using Eurovision.DTO;

namespace Eurovision.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{
    private readonly EurovisionAPIContext _context;

    public PlayerController(EurovisionAPIContext context)
    {
        _context = context;
    }

    // GET: api/Player
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Player>>> GetPlayer()
    {
      if (_context.PlayerEntity == null)
      {
          return NotFound();
      }
        return await _context.PlayerEntity.ToListAsync();
    }

    // GET: api/Player/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Player>> GetPlayer(int id)
    {
      if (_context.PlayerEntity == null)
      {
          return NotFound();
      }
        var playerEntity = await _context.PlayerEntity.FindAsync(id);

        if (playerEntity == null)
        {
            return NotFound();
        }

        return playerEntity;
    }

    // PUT: api/Player/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPlayerEntity(int id, Player playerEntity)
    {
        if (id != playerEntity.Id)
        {
            return BadRequest();
        }

        _context.Entry(playerEntity).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PlayerEntityExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Player
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Player>> PostPlayerEntity(Player playerEntity)
    {
      if (_context.PlayerEntity == null)
      {
          return Problem("Entity set 'EurovisionAPIContext.PlayerEntity'  is null.");
      }
        _context.PlayerEntity.Add(playerEntity);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPlayerEntity", new { id = playerEntity.Id }, playerEntity);
    }

    // DELETE: api/Player/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlayerEntity(int id)
    {
        if (_context.PlayerEntity == null)
        {
            return NotFound();
        }
        var playerEntity = await _context.PlayerEntity.FindAsync(id);
        if (playerEntity == null)
        {
            return NotFound();
        }

        _context.PlayerEntity.Remove(playerEntity);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PlayerEntityExists(int id)
    {
        return (_context.PlayerEntity?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}
