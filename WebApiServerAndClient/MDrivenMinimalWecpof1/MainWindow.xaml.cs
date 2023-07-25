using Eco.Handles;
using Eco.WPF;

using MDriven.Net.Http;
using System.Windows;

namespace MDrivenMinimalWecpof1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {

    private LocalModel.MDrivenEcoSpace _es;
    public MainWindow()
    {
      InitializeComponent();

      MDrivenRestLogic.Install();
      _es = new LocalModel.MDrivenEcoSpace();
      Eco.ViewModel.Runtime.ViewModelDefinitionsInApplication.Init(_es);
      WPFDequeuer.Active = true;
      wecpof.EasyInit(_es);
      _es.Active = true;
    }


  }
}
