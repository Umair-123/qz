using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchIt.Models;
namespace WatchIt.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        WatchItEntities2 db = new WatchItEntities2();
        public ActionResult MoviesCategories()
        {
            var repository = new MovieRepository();
            return View(repository.GetMovies().OrderBy(m => m.YearReleased));
        }
        public ActionResult SearchMovies()
        {
            return View();
        }
        public JsonResult SearchMoviesAjax(string moviename)
        {
            var q = (from x in db.Movies
                    where x.Title.Contains(moviename)
                    select x).ToList();
                if(q!=null)
                    return this.Json(q, JsonRequestBehavior.AllowGet);
                else
                    return this.Json(false, JsonRequestBehavior.AllowGet);
        }

    }
}
