using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoadTestingWebApp.Startup))]
namespace LoadTestingWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
