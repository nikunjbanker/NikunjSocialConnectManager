using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NikunjSocialConnectManager.Startup))]
namespace NikunjSocialConnectManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
