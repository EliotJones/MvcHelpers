using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EliotJones.RadioButtons.NuGetCheckSite.Startup))]
namespace EliotJones.RadioButtons.NuGetCheckSite
{
    using EliotJones.RadioButtons.NuGetCheckSite;
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