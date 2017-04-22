using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZFX365.Com.Plugin.Order.Startup))]
namespace ZFX365.Com.Plugin.Order
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
