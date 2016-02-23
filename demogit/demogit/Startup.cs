using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demogit.Startup))]
namespace demogit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
