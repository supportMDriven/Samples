
using Eco.DataRepresentation;
using Eco.Handles;
using Eco.Persistence;
using MDriven.Persistence.WebApi;
using MDriven.WebApi.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MDrivenEcoSpaceAndModelProject2;
using System.Web.Security;
using System.Web.Http;


namespace WebApiExampleNamespace.APP_A0
{



#if NETCOREAPP2_0
  [Route("api/[controller]/[action]")]
  [ApiController]
#else
  [Route("api/[controller]")]
#endif
  public class A0_WebApiController : MDrivenPersistenceController<EcoProject1PMP>
  {

    public override void VerifyAuthentication()
    { 
      // in this demo I will let anything pass  
    }

    protected override string TypeNamePrefix()
    {
      return "A0";
    }


    protected override bool VerifyLogin(string user, string password)
    {
      return true;
    }


    protected override void LoggOpportunity(Exception e, bool wasInWrite, string operation)
    {
      base.LoggOpportunity (e, wasInWrite, operation);
    }

  }
}