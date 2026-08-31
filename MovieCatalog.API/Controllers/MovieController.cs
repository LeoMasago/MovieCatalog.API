using MovieCatalog.API.Data;
using MovieCatalog.API.DTOs;
using MovieCatalog.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieCatalog.API.Controllers
{
    [ApiController]
    [Route("api/v1/movies")]
    public class MovieController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        //GET: api/v1/movies
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Movies);
        }

        //GET: api/v1/movies/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            return movie is not null ? Ok(movie) : NotFound();
        }

        //POST: api/v1/movies
        [HttpPost]
        public IActionResult Create([FromBody] MovieRequest request)
        {
            var movie = new Movie
            {
                Id = _context.Movies.Any() ? _context.Movies.Max(m => m.Id) + 1 : 1,
                Titulo = request.Titulo,
                Diretor = request.Diretor,
                AnoLancamento = request.AnoLancamento,
                Genero = request.Genero
            };

            _context.Movies.Add(movie);

            return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
        }

        //PUT: api/v1/movies/{id}
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] MovieRequest request)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie is null)
            {
                return NotFound();
            }

            movie.Titulo = request.Titulo;
            movie.Diretor = request.Diretor;
            movie.AnoLancamento = request.AnoLancamento;
            movie.Genero = request.Genero;

            return Ok(movie);
        }

        //DELETE: api/v1/movies/{id}
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie is null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);

            return NoContent();
        }
    }
}
