using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Caching;
using System.Diagnostics;
using System.Net;
using System.Security.Principal;
using System.Web.Http;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using System.Net.Http;

namespace WebApiExampleNamespace
{
  public class Global : System.Web.HttpApplication
  {


    protected void Application_Start(Object sender, EventArgs e)
    {
      AreaRegistration.RegisterAllAreas();
      RouteConfig.RegisterRoutes(RouteTable.Routes);



      GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always; // WebAPI exception info on error 

    }

    protected void Session_Start(object sender, EventArgs e)
    {
    }
    protected void Application_BeginRequest(object sender, EventArgs e)
    {
     // HttpContext.Current.SkipAuthorization = true;//.Principal.Identity.IsAuthenticated

    }

    void Global_PostAuthorizeRequest(object sender, EventArgs e)
    {
    }


    protected void Application_Error(object sender, EventArgs e)
    {

    }

    protected void Session_End(object sender, EventArgs e)
    {

    }

    protected void Application_End(object sender, EventArgs e)
    {
    }
  }
}