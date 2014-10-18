using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluralsightAspDotNetSecurityPart1.Startup))]
namespace PluralsightAspDotNetSecurityPart1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
