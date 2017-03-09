using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesRepresentative.Startup))]
namespace SalesRepresentative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
