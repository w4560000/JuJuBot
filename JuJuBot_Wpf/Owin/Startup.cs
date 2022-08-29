using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin.StaticFiles.ContentTypes;
using Owin;
using System.IO;
using System.Linq;
using System.Web.Http;

namespace JuJuBot_Wpf.Owin
{
    public class Startup
    {
        // This method is required by Katana:
        public void Configuration(IAppBuilder app)
        {
            var webApiConfiguration = ConfigureWebApi();


            // Use the extension method provided by the WebApi.Owin library:
            app.UseWebApi(webApiConfiguration);

            app.UseStaticFiles();
        }

        private HttpConfiguration ConfigureWebApi()
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{action}");
            return config;
        }
    }
}