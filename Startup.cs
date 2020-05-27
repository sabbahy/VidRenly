using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidRenly.Startup))]
namespace VidRenly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
