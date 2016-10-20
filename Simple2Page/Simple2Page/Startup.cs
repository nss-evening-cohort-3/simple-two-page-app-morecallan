using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple2Page.Startup))]
namespace Simple2Page
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
