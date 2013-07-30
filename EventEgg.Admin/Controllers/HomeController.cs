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
            //response.write("asas");

            Response.Write("ERT:test");
            Response.Write("Omr:test");
            
            
            
            
            // guncelleme yaptim

            // ömer : güncelleme yaptım


            // ömr:test:test
            
            // ömer : alll

            // ertugrul: 16:35

            // ömer :16:36 (ertugrul ekledi)



            return View();
        }
    }
}
