using Microsoft.Extensions.DependencyInjection;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;

namespace MovieStore.BL
{
    public static class DependanciesInjection
    {
        public static IServiceCollection
          RegisterServices(this IServiceCollection services)
        {
            return
                services.AddSingleton<IMoviesService,
                    MoviesService>();
        }
    }
}
