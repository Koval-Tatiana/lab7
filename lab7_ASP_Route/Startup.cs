using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab7_ASP_Route.Startup))]
namespace lab7_ASP_Route
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
