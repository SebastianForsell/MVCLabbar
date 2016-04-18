using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uppgift1.Startup))]
namespace Uppgift1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
