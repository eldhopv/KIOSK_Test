using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KIOSK_Test.Startup))]
namespace KIOSK_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
