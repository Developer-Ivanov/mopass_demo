using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vulnerabilities.Startup))]
namespace Vulnerabilities
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
