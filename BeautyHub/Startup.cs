using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeautyHub.Startup))]
namespace BeautyHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
