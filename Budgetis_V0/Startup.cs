using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Budgetis_V0.Startup))]
namespace Budgetis_V0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
