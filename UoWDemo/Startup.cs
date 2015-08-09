using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UoWDemo.Startup))]
namespace UoWDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
