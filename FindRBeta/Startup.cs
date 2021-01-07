using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindRBeta.Startup))]
namespace FindRBeta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
