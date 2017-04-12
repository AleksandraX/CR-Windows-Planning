using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CR_Planinng.WebUI.Startup))]
namespace CR_Planinng.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
