using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BDD_02.Startup))]
namespace BDD_02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
