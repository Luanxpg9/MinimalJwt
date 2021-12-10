

using MinimalJwt.Models;
using MinimalJwt.Repositories;

namespace MinimalJwt.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);
            return movie;
        }
        
        public Movie Get(int id)
        {

            return MovieRepository.Movies[id];
        }

        public List<Movie> GetMovies()
        {
            return MovieRepository.Movies;
        }

        public Movie Update(Movie movie)
        {
            Movie updatedMovie = new Movie();
            return updatedMovie;
        }

        public bool Delete(int id)
        {

        }
    }
}
