using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(courseothmane.Startup))]
namespace courseothmane
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
