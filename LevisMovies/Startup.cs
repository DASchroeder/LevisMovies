using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LevisMovies.Startup))]
namespace LevisMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
