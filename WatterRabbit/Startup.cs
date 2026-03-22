using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WatterRabbit.Startup))]
namespace WatterRabbit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
