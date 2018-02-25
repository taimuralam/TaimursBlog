using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaimurTheNeonBlog.Startup))]
namespace TaimurTheNeonBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
