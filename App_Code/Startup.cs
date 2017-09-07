using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitTest.Startup))]
namespace gitTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
