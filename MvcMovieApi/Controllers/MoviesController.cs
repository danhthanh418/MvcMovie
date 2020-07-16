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
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return _movieService.Get();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieItem(int? id)
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
        [HttpPut("{id}")]
        public bool PutMovieItem(int id, Movie movieItem)
        {
            return _movieService.Update(id, movieItem);
        }

        // POST: api/Movies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Movie> PostMovieItem(Movie movieItem)
        {
            _movieService.Create(movieItem);
            return CreatedAtAction(nameof(GetMovieItem), new { id = movieItem.Id }, movieItem);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public void DeleteMovieItem(int id)
        {
            var movieItem = _movieService.Find(id);
            _movieService.Delete(movieItem);
        }

        private bool MovieItemExists(int? Id)
        {
            return _movieService.Find(Id) != null;
        }
    }
}
