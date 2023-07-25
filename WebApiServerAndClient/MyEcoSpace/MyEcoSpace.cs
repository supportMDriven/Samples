namespace WebApiExampleNamespace
{
  using System;
  using System.Collections.Generic;
  using Eco.Handles;
  using Eco.Services;
  using Eco.UmlCodeAttributes;
  using Eco.Cache;
  using Eco.Persistence;
  using Eco.Ocl.Support;
  using MDriven.WebApi.Client;
  using System.Threading;
  using System.IO;

  [EcoSpace]
  [UmlTaggedValue("Eco.InitializeNullableStringsToNull", "true")]
  [UmlTaggedValue("Eco.GenerateMultiplicityConstraints", "true")]
  public partial class MyEcoSpace : DefaultEcoSpace
  {
    #region Eco Managed code
    private static ITypeSystemService typeSystemProvider;
    #endregion Eco Managed code

    public MyEcoSpace()
      : base()
    {
      this.InitializeComponent();


      EcoServiceProvider.RegisterEcoService<ICache>(FrontsidePolicy.Cache);

    }
    private DateTime _creationTime;








    #region Eco Managed code
    public static new ITypeSystemService GetTypeSystemService()
    {
      if (typeSystemProvider == null)
      {
        lock (typeof(MyEcoSpace))
        {
          if (typeSystemProvider == null)
            typeSystemProvider = MakeTypeService(typeof(MyEcoSpace));
        }
      }

      return typeSystemProvider;
    }

    protected override ITypeSystemService GetTypeSystemProvider()
    {
      return MyEcoSpace.GetTypeSystemService();
    }
    #endregion

    public void UpdateDatabase()
    {
      if ((Persistence != null) && (DirtyList != null))
      {
        Persistence.UpdateDatabaseWithList(DirtyList.AllDirtyObjects());
      }
    }

    public void Refresh()
    {
      EcoServiceHelper.GetEcoService<IPersistenceService>(this).Refresh(true);
    }

  }
}
