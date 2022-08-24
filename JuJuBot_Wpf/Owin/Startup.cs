using Owin;
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
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            return config;
        }
    }
}