using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EliotJones.RadioButtons.WebSample.Startup))]
namespace EliotJones.RadioButtons.WebSample
{
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}