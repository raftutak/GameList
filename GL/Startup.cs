using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GL.Startup))]
namespace GL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
