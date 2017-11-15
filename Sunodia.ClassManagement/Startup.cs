using Microsoft.Owin;
using Owin;
using Sunodia.ClassManagement;

[assembly: OwinStartupAttribute(typeof(Startup))]
namespace Sunodia.ClassManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
