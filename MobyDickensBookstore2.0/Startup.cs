using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobyDickensBookstore2._0.Startup))]
namespace MobyDickensBookstore2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
