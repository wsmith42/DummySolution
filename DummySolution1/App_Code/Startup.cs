using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DummySolution.Startup))]
namespace DummySolution
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
