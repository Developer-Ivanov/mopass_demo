using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mssql.Startup))]
namespace Mssql
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
