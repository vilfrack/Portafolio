using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portafolio.Startup))]
namespace Portafolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
