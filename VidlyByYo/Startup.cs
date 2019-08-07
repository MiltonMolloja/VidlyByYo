using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyByYo.Startup))]
namespace VidlyByYo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
