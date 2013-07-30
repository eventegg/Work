using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using EventEgg.Data.Repositories;

namespace EventEgg.Admin
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void FormsAuthentication_OnAuthenticate(Object sender, FormsAuthenticationEventArgs e)
        {
            if (FormsAuthentication.CookiesSupported)
            {
                if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    string username = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;

                    var roles = string.Empty;

                    using (var service = new PersonalRepository())
                    {
                        roles = service.GetRole(username);
                    }

                    e.User = new System.Security.Principal.GenericPrincipal(new System.Security.Principal.GenericIdentity(username, "Forms"), roles.Split(';'));
                }
            }
        }
    }
}