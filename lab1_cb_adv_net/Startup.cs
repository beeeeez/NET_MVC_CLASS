using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab1_cb_adv_net.Startup))]
namespace lab1_cb_adv_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
