using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchIt.Models
{
    public class ImplementMovie:MovieInterface
    {
        WatchItEntities2 db = new WatchItEntities2();
        public Boolean saveMovie(Movie movie) {
            db.Movies.Add(movie);
            db.SaveChanges();
            return true;
        }
    }
}