using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkDaily.Startup))]
namespace WorkDaily
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
