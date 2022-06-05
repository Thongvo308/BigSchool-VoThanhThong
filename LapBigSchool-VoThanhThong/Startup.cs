using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LapBigSchool_VoThanhThong.Startup))]
namespace LapBigSchool_VoThanhThong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
