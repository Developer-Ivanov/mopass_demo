using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sqli.Startup))]
namespace Sqli
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
