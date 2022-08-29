using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace JuJuBot_Wpf.Owin.Controllers
{
    public class BotController : ApiController
    {
        [HttpGet, Route(nameof(GetIndex))]
        public HttpResponseMessage GetIndex()
        {
            var html = System.IO.File.ReadAllText(@"./Owin/html/Index.html");
            var res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(html, Encoding.UTF8, "text/html");

            return res;
        }

        [HttpGet, Route(nameof(GetSample))]
        public HttpResponseMessage GetSample()
        {
            var html = System.IO.File.ReadAllText(@"./Owin/html/Sample.html");
            var res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(html, Encoding.UTF8, "text/html");

            return res;
        }
    }
}