using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SisAuto.Startup))]
namespace SisAuto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
