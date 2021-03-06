﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace SecurityPipelineDemo.Pipeline
{
    public class TestAuthorizationFilterAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {

            Helper.Write("Authorization Filter", actionContext.RequestContext.Principal);

            return true;
            //return base.IsAuthorized(actionContext);
        }
    }
}