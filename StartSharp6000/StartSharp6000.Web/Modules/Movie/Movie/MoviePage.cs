using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace StartSharp6000.Movie.Pages
{

    [PageAuthorize(typeof(MovieRow))]
    public class MovieController : Controller
    {
        [Route("Movie/Movie")]
        public ActionResult Index()
        {
            return View("~/Modules/Movie/Movie/MovieIndex.cshtml");
        }
    }
}