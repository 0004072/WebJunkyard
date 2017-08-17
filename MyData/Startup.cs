using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyData.Startup))]
namespace MyData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
