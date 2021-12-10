﻿using MinimalJwt.Models;

namespace MinimalJwt.Services
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);
        public Movie Get(int id);
        public List<Movie> GetMovies();
        public Movie Update (Movie movie);
        public bool Delete(int id);

    }
}
