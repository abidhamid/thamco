using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThAmCo.Startup))]
namespace ThAmCo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
