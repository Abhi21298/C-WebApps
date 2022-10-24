using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication10Exercise3.Startup))]
namespace WebApplication10Exercise3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
