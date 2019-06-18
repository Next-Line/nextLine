using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Next_Line.Startup))]
namespace Next_Line
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
