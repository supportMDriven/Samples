namespace LocalModel
{
  public partial class MDrivenEcoSpace
  {
    /// <summary>
    /// Required designer variable
    /// </summary>
    private System.ComponentModel.Container components = null;
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        Active = false;
        if (this.components != null)
        {
          this.components.Dispose();
        }
      }

      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.persistenceMapperWEBAPIClient1 = new MDriven.WebApi.Client.PersistenceMapperWEBAPIClient();
      // 
      // persistenceMapperWEBAPIClient1
      // 
      this.persistenceMapperWEBAPIClient1.FailedConnectionRetryMaxSeconds = 20;
      this.persistenceMapperWEBAPIClient1.FailedConnectionRetryTimes = 3;
      this.persistenceMapperWEBAPIClient1.ServerPassword = null;
      this.persistenceMapperWEBAPIClient1.ServerUserName = null;
      this.persistenceMapperWEBAPIClient1.Uri = "http://localhost:62377/API/A0_WebApi";
      // 
      // MDrivenEcoSpace
      // 
      this.PersistenceMapper = this.persistenceMapperWEBAPIClient1;

    }
    private MDriven.WebApi.Client.PersistenceMapperWEBAPIClient persistenceMapperWEBAPIClient1;
    protected Package1.Package1Package IncludeEcoPackage_Package1_Package1Package;
  }
}
