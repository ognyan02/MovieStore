using Microsoft.AspNetCore.Mvc;
using MovieStore.Models.DTO;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _movieService;

        public MoviesController(IMoviesService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Movie> Get()
        {
            return _movieService.GetAll();
        }

        [HttpPost("Add")]
        public void Add(Movie movie)
        {
            _movieService.Add(movie);
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            var movie = _movieService.GetById(id);
            if (movie == null)
            {
                return NotFound($"Movie with ID {id} not found.");
            }
            return Ok(movie);
        }
    }
}
