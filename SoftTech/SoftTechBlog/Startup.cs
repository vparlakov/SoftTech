using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftTechBlog.Startup))]
namespace SoftTechBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
