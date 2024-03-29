//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Package1 {
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.CodeDom.Compiler;
  using Eco.ObjectImplementation;
  using Eco.ObjectRepresentation;
  using Eco.Services;
  using Eco.Subscription;
  using Eco.UmlCodeAttributes;
  using Eco.UmlRt;
  
  
  [UmlElement(Id="9705dc45-b787-43d9-a81d-76eebb8a128d")]
  [Eco.UmlCodeAttributes.PreserveAttribute()]
  public partial class Class1 : Eco.ObjectImplementation.ILoopBack3, System.ComponentModel.INotifyPropertyChanged {
    
    #region *** Constructors ***
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public Class1(Eco.ObjectRepresentation.IEcoServiceProvider serviceProvider) {
      this.Initialize(serviceProvider);
      try {
        this.ObjectCreated();
      }
      catch (System.Exception ) {
        this.Deinitialize(serviceProvider);
        throw;
      }
    }
    
    /// <summary>
    /// For framework internal use only
    /// Constructor public for one reason only; to avoid need for ReflectionPermission in reduced trust
    /// </summary>
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public Class1(Eco.ObjectImplementation.IContent content) {
      this.eco_Content = content;
      content.AssertLoopbackUnassigned();
      this.ObjectFetched();
    }
    
    /// <summary>
    /// Creates an Offline object. Can for example be used by MVC runtime to pass values
    /// This is type equivalent to the eco object in everyway - but has none of the eco services
    /// It does however implement INotifyPropertyChanged and INotifyCollectionChanged
    /// </summary>
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public Class1() {
      this.eco_Content = new EcoOfflineValues();
      this.ObjectCreated();
    }
    
    /// <summary>This method is called when the object has been created the first time (not when loaded from a db)</summary>
    partial void ObjectCreated();
    
    /// <summary>This method is called when the object has been loaded from a db (not when it is created the first time)</summary>
    partial void ObjectFetched();
    
    /// <summary>This method is called before the object is deleted. You can perform custom clean up or prevent the deletion by returning false or throw an exception (preferably EcoObjectDeleteException)</summary>
    partial void PreDelete(ref System.Boolean canDelete);
    
    #endregion *** Constructors ***
    
    #region *** ILoopback implementation ***
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public virtual void set_MemberByIndex(int index, object value) {
      throw new System.IndexOutOfRangeException();
    }
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public virtual object get_MemberByIndex(int index) {
      throw new System.IndexOutOfRangeException();
    }
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    Eco.ObjectRepresentation.IObject Eco.ObjectRepresentation.IObjectProvider.AsIObject() {
      return this.eco_Content.AsIObject();
    }
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    void Eco.ObjectImplementation.ILoopBack2.SetContent(Eco.ObjectImplementation.IContent content) {
      if ((this.eco_Content != null)) {
        throw new System.InvalidOperationException();
      }
      this.eco_Content = content;
    }
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    Eco.ObjectImplementation.IContent Eco.ObjectImplementation.ILoopBack3.GetContent() {
      return this.eco_Content;
    }
    
    #endregion *** ILoopback implementation ***
    
    #region *** LoopbackIndex declarations ***
    
    public struct Eco_LoopbackIndices {
      
      public const int Eco_FirstMember = 0;
      
      public const int Attribute2 = Eco_FirstMember;
      
      public const int Attribute3 = (Attribute2 + 1);
      
      public const int Attribute1 = (Attribute3 + 1);
      
      public const int Class2 = (Attribute1 + 1);
      
      public const int Eco_MemberCount = (Class2 + 1);
    }
    
    #endregion *** LoopbackIndex declarations ***
    
    #region *** IObjectProvider implementation ***
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public virtual Eco.ObjectRepresentation.IObjectInstance AsIObject() {
      return this.eco_Content.AsIObject();
    }
    
    #endregion *** IObjectProvider implementation ***
    
    #region *** INotifyPropertyChanged implementation ***
    
    event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
    
      add { eco_Content.PropertyChanged += value; }
    
      remove { eco_Content.PropertyChanged -= value; }
    
    }
    
    #endregion *** INotifyPropertyChanged implementation ***
    
    #region *** ECO framework implementations ***
    
    protected Eco.ObjectImplementation.IContent eco_Content;
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    protected virtual void Initialize(Eco.ObjectRepresentation.IEcoServiceProvider serviceProvider) {
      if ((this.eco_Content == null)) {
        Eco.ObjectImplementation.IInternalObjectContentFactory factory = serviceProvider.GetEcoService<Eco.ObjectImplementation.IInternalObjectContentFactory>();
        factory.CreateContent(this);
        this.eco_Content.LoopbackValid();
      }
    }
    
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    protected virtual void Deinitialize(Eco.ObjectRepresentation.IEcoServiceProvider serviceProvider) {
      if ((this.eco_Content == null)) {
        Eco.ObjectImplementation.IInternalObjectContentFactory factory = serviceProvider.GetEcoService<Eco.ObjectImplementation.IInternalObjectContentFactory>();
        factory.CreateContentFailed(this.eco_Content, this);
        this.eco_Content = null;
      }
    }
    
    #endregion *** ECO framework implementations ***
    
    [UmlTaggedValue("Eco.AllowNULL", "True")]
    [UmlElement(Id="59393b48-1660-4029-9fdb-50da630da77b", Index=Eco_LoopbackIndices.Attribute2)]
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public string Attribute2 {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.Attribute2, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.Attribute2, ((object)(value)), "Attribute2");
      }
    }
    
    [UmlTaggedValue("Eco.AllowNULL", "True")]
    [UmlElement(Id="9f03ea3b-e166-4613-9d45-92ef190f02a6", Index=Eco_LoopbackIndices.Attribute3)]
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public string Attribute3 {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.Attribute3, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.Attribute3, ((object)(value)), "Attribute3");
      }
    }
    
    [UmlTaggedValue("Eco.AllowNULL", "True")]
    [UmlElement(Id="dde76b97-d737-464e-89c3-a53f68a3f7c9", Index=Eco_LoopbackIndices.Attribute1)]
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public string Attribute1 {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.Attribute1, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.Attribute1, ((object)(value)), "Attribute1");
      }
    }
    
    [UmlElement("AssociationEnd", Id="56fd2855-bdb1-4b63-b0dc-a4167526fb21", Index=Eco_LoopbackIndices.Class2)]
    [UmlMetaAttribute("association", typeof(Package1Package.Class2Class2Class1Class1), Index=1)]
    [UmlMetaAttribute("multiplicity", "0..*")]
    [GeneratedCodeAttribute("ECO", "7.1.0.0")]
    public IEcoList<Class2> Class2 {
      get {
        return ((IEcoList<Class2>)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.Class2, typeof(IEcoList<Class2>))));
      }
    }
  }
}
