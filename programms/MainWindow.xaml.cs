using Microsoft.UI.Text;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.IO;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Graphics;
using Windows.Storage;
using Windows.Storage.Streams;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace One_Lesson
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RescaleElements(Bounds.Width, Bounds.Height);
            SizeChanged += WindowOnSizeChanged;
            OpenFile(App.initialFile);
            RichEditTextDocument truc = DocumentContent.Document;
            SetTitleBar(CustomDragRegion);
            ExtendsContentIntoTitleBar = true;
        }

        private void RescaleElements(double width, double height)
        {
            TabBar.Width = width;
            MenuBarContainer.Width = width;
            DocumentContent.Width = width;
            var newdocumentcontentheight = height - TabBar.ActualHeight - MenuBarContainer.ActualHeight;
            if (InfoBar.IsOpen)
            {
                newdocumentcontentheight -= InfoBar.ActualHeight;
            }
            DocumentContent.Height = newdocumentcontentheight;
        }

        private void InfoBarMessage(string title, string message, InfoBarSeverity severity)
        {
            InfoBar.Title = title;
            InfoBar.Message = message;
            InfoBar.Severity = severity;
            InfoBar.IsOpen = true;
            RescaleElements(Bounds.Width, Bounds.Height);
            _ = CloseInfoBarAfterDelay();
            async Task CloseInfoBarAfterDelay()
            {
                await Task.Delay(5000);
                InfoBar.IsOpen = false;
                RescaleElements(Bounds.Width, Bounds.Height);
            }
        }

        private void WindowOnSizeChanged(object sender, WindowSizeChangedEventArgs args)
        {
            RescaleElements(args.Size.Width, args.Size.Height);
        }
    }
}
