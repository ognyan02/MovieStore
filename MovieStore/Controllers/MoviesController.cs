using Microsoft.AspNetCore.Mvc;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.BL.Interfaces;
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
    }
}
