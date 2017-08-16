using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectionApp.Startup))]
namespace ElectionApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
