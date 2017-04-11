using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;

namespace SecurityPipelineDemo.Pipeline
{
    public class TestMiddleware
    {
        private Func<IDictionary<string, object>, Task> _next;

        public TestMiddleware(Func<IDictionary<string, object>, Task> next)
        {
            _next = next;
        }
        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);

            // authentication

            context.Request.User = new GenericPrincipal(new GenericIdentity("Ramanajee"), new string[] { });

            Helper.Write("Middlerware", context.Request.User);
            await _next(env);
        }
    }
}