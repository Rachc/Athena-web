using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Athena_web.Startup))]
namespace Athena_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
