using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sales1._0.Backend.Startup))]
namespace Sales1._0.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
