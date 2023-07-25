namespace MDrivenEcoSpaceAndModelProject2
{
  public partial class EcoProject1PMP
  {
    #region Component Designer generated code
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    private Eco.Persistence.SyncHandler syncHandler1;

    private Eco.Persistence.PersistenceMapperXml persistenceMapperXml1;

    private void InitializeComponent()
    {
      this.persistenceMapperXml1 = new Eco.Persistence.PersistenceMapperXml();
      this.syncHandler1 = new Eco.Persistence.SyncHandler();
      // 
      // persistenceMapperXml1
      // 
      this.persistenceMapperXml1.FileName = "Data.xml";
      this.persistenceMapperXml1.SyncHandler = this.syncHandler1;
      // 
      // syncHandler1
      // 
      this.syncHandler1.HistoryLength = 10000;
      // 
      // EcoProject1PMP
      // 
      this.EcoSpaceTypeName = "WebApiExampleNamespace.MyEcoSpace";
      this.PersistenceMapper = this.persistenceMapperXml1;

    }
    #endregion
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.components != null)
        {
          this.components.Dispose();
        }
      }

      base.Dispose(disposing);
    }
  }
}
