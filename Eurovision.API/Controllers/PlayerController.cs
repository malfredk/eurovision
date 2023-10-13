using Microsoft.AspNetCore.Mvc;
using Eurovision.DTO;
using Eurovision.API.Repository.Contract;
using AutoMapper;

namespace Eurovision.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{
    private readonly IPlayerRepository _repository;
    private readonly IMapper _mapper;

    public PlayerController(IPlayerRepository repository,
                            IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    // GET: api/Player
    [HttpGet]
    public ActionResult<IEnumerable<Player>> GetPlayers()
    {
        try
        {
            var players = _repository.GetPlayers();

            if (players == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(players.Select(player => _mapper.Map<Player>(player)));
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    /*

    // GET: api/Player/5
    [HttpGet("{id}")]
    public ActionResult<Player> GetPlayer(int id)
    {
      if (.PlayerEntity == null)
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
    */
}
