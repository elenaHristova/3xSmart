using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brain.Startup))]
namespace Brain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
