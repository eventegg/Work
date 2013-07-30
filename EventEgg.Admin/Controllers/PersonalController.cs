using System.Web.Mvc;
using EventEgg.Admin.Models;
using System.Web.Security;
using EventEgg.Data.Repositories;

namespace EventEgg.Admin.Controllers
{
    public class PersonalController : Controller
    {
        private PersonalRepository _personalRepository;

        /// <summary>
        /// Login Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            var model = new PersonalLoginPageModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(PersonalLoginPageModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = true;
            }

            if (ModelState.IsValid)
            {
                _personalRepository = new PersonalRepository();

                if (!_personalRepository.IsAuthenticate(model.Email, model.Password))
                {
                    TempData["Error"] = true;
                    ModelState.AddModelError("loginError", "Kullanıcı bilgileriniz hatalı görünüyor.");
                }
                else
                {
                    // TODO: BU AŞAMADA YAPILACAKLAR
                    // User nesnesini oluştur. 
                    // Kullanıcının rolüne göre yetkilerini ata
                    // User nesnesini Session'a at
                    // Workflow'a gönder (Bu bölümde giriş yaptığı saat gibi bilgiler tutulacak)
                    // ....

                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return new RedirectResult(@"~/Home");
                    }

                }
            }
            return View(model);
        }

        /// <summary>
        /// Register Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Lost Password Page
        /// </summary>
        /// <returns></returns>
        public ActionResult LostPassword()
        {
            return View();
        }

        [Authorize(Roles = "SystemAdmin")]
        public ActionResult Add()
        {
            var model = new PersonalAddPageModel();
            return View(model);
        }

        [Authorize(Roles = "SystemAdmin")]
        [HttpPost]
        public ActionResult Add(PersonalAddPageModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View(model);
        }

        public RedirectResult LogOut()
        {
            FormsAuthentication.SignOut();
            return new RedirectResult("/Personal/Login");
        }
    }
}
