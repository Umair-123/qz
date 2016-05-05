using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchIt.Models
{
    public class MovieRepository
    {
        List<Movies> _movies;

        public  MovieRepository()
        {
            _movies = new List<Movies>();

            _movies.Add(new Movies { MovieId = 1, Title = "The Matrix", Director = "Andy Wachowski/Lana Wachowski", YearReleased = 1999, PosterImage = "the_matrix.jpg" });
            _movies.Add(new Movies { MovieId = 2, Title = "The Matrix Reloaded", Director = "Andy Wachowski/Lana Wachowski", YearReleased = 2003, PosterImage = "reloaded.jpg" });
            _movies.Add(new Movies { MovieId = 3, Title = "The Matrix Revolutions", Director = "Andy Wachowski/Lana Wachowski", YearReleased = 2003, PosterImage = "revolutions.jpg" });

            _movies.Add(new Movies { MovieId = 4, Title = "The Bourne Identity", Director = "Doug Liman", YearReleased = 2002, PosterImage = "bourne_identity.jpg" });
            _movies.Add(new Movies { MovieId = 5, Title = "The Bourne Supremacy", Director = "Paul Greengrass", YearReleased = 2004, PosterImage = "bourne_supremacy.jpg" });
            _movies.Add(new Movies { MovieId = 6, Title = "The Bourne Ultimatum", Director = "Paul Greengrass", YearReleased = 2007, PosterImage = "bourne_ultimatum.jpg" });
            _movies.Add(new Movies { MovieId = 7, Title = "The Bourne Legacy", Director = "Tony Gilroy", YearReleased = 2012, PosterImage = "bourne_legacy.jpg" });

            _movies.Add(new Movies { MovieId = 8, Title = "A New Hope", Director = "George Lucas", YearReleased = 1977, PosterImage = "a_new_hope.jpg" });
            _movies.Add(new Movies { MovieId = 9, Title = "The Empire Strikes Back", Director = "Irvin Kershner", YearReleased = 1980, PosterImage = "empire_strikes_back.jpg" });
            _movies.Add(new Movies { MovieId = 10, Title = "Return of the Jedi", Director = "Richard Marquand", YearReleased = 1983, PosterImage = "return_of_the_jedi.jpg" });

        }

        public List<Movies> GetMovies()
        {
            return _movies;
        }
    }
}