using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MANUALESNETASPCSHARPMVC.Startup))]
namespace MANUALESNETASPCSHARPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
