using Microsoft.Owin;
using Owin;
using TrendTestApp.Web;

[assembly: OwinStartupAttribute(typeof(TrendTestApp.WebApp.Startup))]
namespace TrendTestApp.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IoCInit.InitialiseIoC(app);
            ConfigureAuth(app);
        }
    }
}
