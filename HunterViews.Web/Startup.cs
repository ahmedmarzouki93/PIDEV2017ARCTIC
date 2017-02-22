using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HunterViews.Web.Startup))]
namespace HunterViews.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
