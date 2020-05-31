using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidzy.Startup))]
namespace Vidzy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
