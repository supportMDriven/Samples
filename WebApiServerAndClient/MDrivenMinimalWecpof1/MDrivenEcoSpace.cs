using Eco.Handles;
using Eco.Linq;
using Eco.Services;
using Eco.UmlCodeAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LocalModel
{
  [EcoSpace]
  [UmlTaggedValue("Eco.InitializeNullableStringsToNull", "true")]
  [UmlTaggedValue("Eco.GenerateMultiplicityConstraints", "true")]
  public partial class MDrivenEcoSpace : Eco.Handles.DefaultEcoSpace
  {
    #region Eco Managed code
    private static ITypeSystemService typeSystemProvider;
    #endregion Eco Managed code

    public MDrivenEcoSpace() : base()
    {
      this.InitializeComponent();
    }

    /// <summary>
    /// Persist all changes to the domain objects.
    /// </summary>
    /// <remarks>
    /// This function persists all changes to the eco space, including object creation,
    /// object manipulation, changed associations and object deletions. After invoking this method
    /// all undo information is removed.
    /// If the application does not have any persistence layer defined the operation does nothing.
    /// </remarks>
    public void UpdateDatabase()
    {
      if ((Persistence != null) && (DirtyList != null))
      {
        Persistence.UpdateDatabaseWithList(DirtyList.AllDirtyObjects());
      }
    }

    #region Eco Managed code
    public static new ITypeSystemService GetTypeSystemService()
    {
      if (typeSystemProvider == null)
      {
        lock (typeof(MDrivenEcoSpace))
        {
          if (typeSystemProvider == null)
            typeSystemProvider = MakeTypeService(typeof(MDrivenEcoSpace));
        }
      }

      return typeSystemProvider;
    }

    protected override ITypeSystemService GetTypeSystemProvider()
    {
      return MDrivenEcoSpace.GetTypeSystemService();
    }
    #endregion

    // Add user written methods here
  }
}
