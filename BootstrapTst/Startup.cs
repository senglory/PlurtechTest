using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapTst.Startup))]
namespace BootstrapTst
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
