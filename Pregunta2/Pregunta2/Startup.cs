using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pregunta2.Startup))]
namespace Pregunta2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
