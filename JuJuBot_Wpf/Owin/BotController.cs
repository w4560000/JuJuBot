using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace JuJuBot_Wpf.Owin.Controllers
{
    public class BotController : ApiController
    {
        public HttpResponseMessage GetBot()
        {
            var html = System.IO.File.ReadAllText(@"./Owin/html/Index.html");
            var res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(html, Encoding.UTF8, "text/html");

            return res;
        }
    }
}