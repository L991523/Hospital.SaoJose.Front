using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospital.SaoJose.Front.Startup))]
namespace Hospital.SaoJose.Front
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
