using Eco.Handles;
using Eco.MVC;
using Eco.ObjectRepresentation;
using Eco.UmlRt;
using Eco.ViewModel.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#if NETCOREAPP2_0
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
#else
using System.Web.Mvc;
#endif


namespace WebApiExampleNamespace.Controllers
{


  public class ESWrapperForA0 : IEcoSpaceCacheWrapper
  {
    public DefaultEcoSpace EcoSpace { get; set; }
  }
  public class TheA0EcoSpaceProvider : IEcoSpaceCacheProvider
  {
    public string Info { get; internal set; }

    public IEcoSpaceCacheWrapper BorrowAgain(IEcoSpaceCacheWrapper ecoSpaceWrapperInterface)
    {
      throw new Exception("not implemented");
    }

    public IEcoSpaceCacheWrapper BorrowEcoSpace(EcoSpaceRequestInfo requestInfo)
    {
      var res = new ESWrapperForA0() {EcoSpace= new MyEcoSpace() };


      return res;
    }


    public void ReturnEcoSpace(IEcoSpaceCacheWrapper ecoSpaceWrapperInterface)
    {
      ecoSpaceWrapperInterface.EcoSpace.Active = false;
    }
  }

  public class Data_A0Controller : ModelDrivenControllerBase<WebApiExampleNamespace.MyEcoSpace>
  {

    public Data_A0Controller()
    {
      this.EcoSpaceProvider = new TheA0EcoSpaceProvider();

    }

    protected override void OnActionExecuting(ActionExecutingContext filterContext)
    {



      base.OnActionExecuting(filterContext);


    }










  }

}