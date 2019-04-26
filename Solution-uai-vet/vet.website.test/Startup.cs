using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vet.website.test.Startup))]
namespace vet.website.test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
