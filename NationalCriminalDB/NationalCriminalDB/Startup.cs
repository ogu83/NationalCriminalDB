using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NationalCriminalDB.Startup))]
namespace NationalCriminalDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
