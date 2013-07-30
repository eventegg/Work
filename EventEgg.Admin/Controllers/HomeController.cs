using System.Web.Mvc;

namespace EventEgg.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [Authorize(Roles = "SystemAdmin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
