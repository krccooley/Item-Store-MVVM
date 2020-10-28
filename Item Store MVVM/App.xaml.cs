using System.Windows;
using GalaSoft.MvvmLight.Threading;

namespace Item_Store_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
            //Shows the configuration window on start up
            Window.Configuration configurationWindow = new Window.Configuration();
            configurationWindow.Show();
        }
    }
}
