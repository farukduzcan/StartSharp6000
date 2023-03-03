using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace StartSharp6000.Movie.Pages
{

    [PageAuthorize(typeof(GenreRow))]
    public class GenreController : Controller
    {
        [Route("Movie/Genre")]
        public ActionResult Index()
        {
            return View("~/Modules/Movie/Genre/GenreIndex.cshtml");
        }
    }
}