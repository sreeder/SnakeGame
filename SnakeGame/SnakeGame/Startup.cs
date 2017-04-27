using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SnakeGame.Startup))]
namespace SnakeGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
