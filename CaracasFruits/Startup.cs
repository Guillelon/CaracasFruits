using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaracasFruits.Startup))]
namespace CaracasFruits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
