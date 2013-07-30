using EventEgg.Admin.Models;
using EventEgg.Data.Repositories;
using System.Web.Mvc;
using System.Web.Security;

namespace EventEgg.Admin.Controllers
{
    public class MenuController : Controller
    {
        private PersonalRepository _personalRepository;

        public PartialViewResult MenuHeader()
        {
            _personalRepository = new PersonalRepository();
            var model = new MenuHeaderPageModel();
            var httpCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            if (httpCookie != null)
            {
                var email = FormsAuthentication.Decrypt(httpCookie.Value).Name;
                var personalDetail = _personalRepository.SingleBy(k => k.Email == email);
                model.FullName = personalDetail.FirstName + " " + personalDetail.LastName;
            }
            return PartialView(model);
        }
        public PartialViewResult MenuLeft()
        {
            return PartialView();
        }
        public PartialViewResult MenuFooter()
        {
            return PartialView();
        }
    }
}
