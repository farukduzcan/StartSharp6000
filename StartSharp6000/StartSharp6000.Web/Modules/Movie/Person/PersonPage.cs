using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace StartSharp6000.Movie.Pages
{

    [PageAuthorize(typeof(PersonRow))]
    public class PersonController : Controller
    {
        [Route("Movie/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/Movie/Person/PersonIndex.cshtml");
        }
    }
}