using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using System.Linq;
using System;
using Microsoft.Windows.AppLifecycle;
using System.Security.Cryptography.X509Certificates;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace One_Lesson
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        public static Window mainWindow;
        public static IStorageFile initialFile;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            AppActivationArguments appActivationArguments = AppInstance.GetCurrent().GetActivatedEventArgs();
            initialFile = null;
            if (appActivationArguments.Kind is ExtendedActivationKind.File &&
                appActivationArguments.Data is IFileActivatedEventArgs fileActivatedEventArgs &&
                fileActivatedEventArgs.Files.FirstOrDefault() is IStorageFile storageFile)
            {
                initialFile = storageFile;
            }
            mainWindow = new MainWindow();
            mainWindow.Activate();
        }
    }
}
