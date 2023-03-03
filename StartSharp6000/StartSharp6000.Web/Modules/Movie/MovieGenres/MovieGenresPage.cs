using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace StartSharp6000.Movie.Pages
{

    [PageAuthorize(typeof(MovieGenresRow))]
    public class MovieGenresController : Controller
    {
        [Route("Movie/MovieGenres")]
        public ActionResult Index()
        {
            return View("~/Modules/Movie/MovieGenres/MovieGenresIndex.cshtml");
        }
    }
}