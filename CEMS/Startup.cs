using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CEMS.Startup))]
namespace CEMS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
