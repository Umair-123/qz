using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchIt.Models;
namespace WatchIt.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        WatchItEntities2 db = new WatchItEntities2();
        MovieInterface mi;
        public MovieController(MovieInterface i) 
        {
            mi = i;
        }
        
        public ActionResult UploadMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveMovie(Movie movie)
        {
            movie.Director=Request["Director"];
            movie.Title = Request["Title"];
            movie.Genre = Request["Genre"];
            movie.YearReleased = Request["YearReleased"];
            mi.saveMovie(movie);
            HttpPostedFileBase file = Request.Files[0];
            file.SaveAs(Server.MapPath(@"~\Images\" + file.FileName));
                        
            return RedirectToAction("UploadMovie");
        
        }
      

    }
}