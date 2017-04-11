using System.Net.Http;
using System.Web.Http;
namespace SecurityPipelineDemo.Pipeline
{
    [TestAuthenticationFilter]
    [TestAuthorizationFilter]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            Helper.Write("Controller ",User);
            return Ok();
        }
    }
}