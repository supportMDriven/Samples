namespace WebApiExampleNamespace
{
    public partial class MyEcoSpace
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
      this.persistenceMapperSharer1 = new Eco.Persistence.PersistenceMapperSharer();
      // 
      // persistenceMapperSharer1
      // 
      this.persistenceMapperSharer1.MapperProviderTypeName = null;
      // 
      // AppCompleteAdminEcoSpace
      // 
      this.PersistenceMapper = this.persistenceMapperSharer1;

        }

    protected Package1.Package1Package IncludeEcoPackage_Package1_Package1Package;
    private Eco.Persistence.PersistenceMapperSharer persistenceMapperSharer1;
  }
}
