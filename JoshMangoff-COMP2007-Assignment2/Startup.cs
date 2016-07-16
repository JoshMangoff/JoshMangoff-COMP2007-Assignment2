using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JoshMangoff_COMP2007_Assignment2.Startup))]
namespace JoshMangoff_COMP2007_Assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
