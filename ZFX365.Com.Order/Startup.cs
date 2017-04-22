using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZFX365.Com.Order.Startup))]
namespace ZFX365.Com.Order
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
