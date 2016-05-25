using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialViewAjax.Startup))]
namespace PartialViewAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
