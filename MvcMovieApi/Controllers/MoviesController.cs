using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovieApi.Models;
using MongoDB.Driver;
using MvcMovieApi.Services;

namespace MvcMovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        //private readonly MovieContext _context;
        private readonly MovieService _movieService;

        public MoviesController(MovieService movieService)
        {
            //_context = context;
            _movieService = movieService;
        }

        // GET: api/Movies
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<MovieItem>>> GetMovieItems()
        //{
        //    return await _context.MovieItems.ToListAsync();
        //}
        [HttpGet]
        public ActionResult<List<MovieItem>> Get()
        {
            return _movieService.Get();
        }

        // GET: api/Movies/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<MovieItem>> GetMovieItem(int id)
        //{
        //    var movieItem = await _context.MovieItems.FindAsync(id);

        //    if (movieItem == null)
        //    {
        //        return NotFound();
        //    }

        //    return movieItem;
        //}        

        [HttpGet("{id}")]
        public ActionResult<MovieItem> GetMovieItem(int id)
        {
            var movieItem = _movieService.Get(id);

            if (movieItem == null)
            {
                return NotFound();
            }

            return movieItem;
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMovieItem(int id, MovieItem movieItem)
        //{
        //    if (id != movieItem.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(movieItem).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MovieItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Movies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<MovieItem>> PostMovieItem(MovieItem movieItem)
        //{
        //    _context.MovieItems.Add(movieItem);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetMovieItem), new { id = movieItem.Id }, movieItem);
        //}
         [HttpPost]
        public ActionResult<MovieItem> PostMovieItem(MovieItem movieItem)
        {
            _movieService.Create(movieItem);
            return CreatedAtAction(nameof(GetMovieItem), new { id = movieItem.Id }, movieItem);
        }

        // DELETE: api/Movies/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<MovieItem>> DeleteMovieItem(int id)
        //{
        //    var movieItem = await _context.MovieItems.FindAsync(id);
        //    if (movieItem == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.MovieItems.Remove(movieItem);
        //    await _context.SaveChangesAsync();

        //    return movieItem;
        //}
        [HttpDelete("{id}")]
        public ActionResult<MovieItem> DeleteMovieItem(int id)
        {
            var movieItem = _movieService.Find(id);
            if (movieItem == null)
            {
                return NotFound();
            }

            _movieService.Delete(movieItem);
            return movieItem;
        }

        private bool MovieItemExists(int Id)
        {
            return _movieService.Find(Id)!= null;
        }
    }
}
