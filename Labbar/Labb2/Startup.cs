using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb2.Startup))]
namespace Labb2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
