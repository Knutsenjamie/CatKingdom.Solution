using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatKingdom.Models;

namespace CatKingdom.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly CatKingdomContext _db;

    public CatsController(CatKingdomContext db)
    {
      _db = db;
    }

    // take out the int if it doesn't work
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get(string breed, string gender, string name, int age, string description)
    {
      var query = _db.Cats.AsQueryable();

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }    

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }    
     
      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }     

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
        var cat = await _db.Cats.FindAsync(id);

        if (cat == null)
        {
            return NotFound();
        }

        return cat;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Cat cat)
    {
      if (id != cat.CatId)
      {
        return BadRequest();
      }

      _db.Entry(cat).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CatExists(id))
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

    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat cat)
    {
      _db.Cats.Add(cat);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);
      if (cat == null)
      {
        return NotFound();
      }

      _db.Cats.Remove(cat);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool CatExists(int id)
    {
      return _db.Cats.Any(e => e.CatId == id);
    }
  }
}