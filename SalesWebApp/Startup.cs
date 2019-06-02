using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesWebApp.Startup))]
namespace SalesWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
