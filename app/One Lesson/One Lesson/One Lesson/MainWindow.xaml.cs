using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using System.Threading.Tasks;
using Microsoft.UI.Windowing;
using Microsoft.UI;
using WinRT.Interop;
using System.ComponentModel;
using Windows.UI.ApplicationSettings;
using Microsoft.UI.Xaml.Core.Direct;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml.Resources;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace One_Lesson
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            SizeChanged += WindowOnSizeChanged;
        }

        private void WindowOnSizeChanged(object sender, Microsoft.UI.Xaml.WindowSizeChangedEventArgs args)
        {
            double newwidth = args.Size.Width;
            double newheight = args.Size.Height;
            TabBar.Width = newwidth;
            MenuBarContainer.Width = newwidth;
            DocumentContent.Width = newwidth;
            DocumentContent.Height = newheight - TabBar.ActualHeight - MenuBarContainer.ActualHeight;
        }

        private void TitleButton_click(object sender, RoutedEventArgs e)
        {
            ITextSelection selectedText = DocumentContent.Document.Selection;
            if (selectedText != null)
            {
                if (selectedText.CharacterFormat.Size == 24)
                {
                    selectedText.CharacterFormat.Bold = FormatEffect.Off;
                    selectedText.CharacterFormat.Size = 12;
                } else
                {
                    selectedText.CharacterFormat.Bold = FormatEffect.On;
                    selectedText.CharacterFormat.Size = 24;
                }
            }
        }

        private void Menu_Opening(object sender, object e)
        {
            CommandBarFlyout contextMenuFlyout = sender as CommandBarFlyout;
            if (contextMenuFlyout.Target == DocumentContent)
            {
                AppBarButton shareButton = new AppBarButton();
                shareButton.Command = new StandardUICommand(StandardUICommandKind.Share);
                AppBarButton setTitle = new();
                setTitle.Label = "Title";
                FontIcon fontIcon = new FontIcon();
                fontIcon.Glyph = "T";
                fontIcon.FontSize = 16;
                fontIcon.FontFamily = new FontFamily("Candara");
                setTitle.Icon = fontIcon;
                setTitle.Click += TitleButton_click;
                contextMenuFlyout.PrimaryCommands.Add(shareButton);
                contextMenuFlyout.PrimaryCommands.Add(setTitle);
            }
        }

        private void DocumentContent_Loaded(object sender, RoutedEventArgs e)
        {
            DocumentContent.SelectionFlyout.Opening += Menu_Opening;
            DocumentContent.ContextFlyout.Opening += Menu_Opening;
        }

        private void DocumentContent_Unloaded(object sender, RoutedEventArgs e)
        {
            DocumentContent.SelectionFlyout.Opening -= Menu_Opening;
            DocumentContent.ContextFlyout.Opening -= Menu_Opening;
        }

        private void TabView_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                (sender as TabView).TabItems.Add(CreateNewTab(i));
            }
        }

        private void TabView_AddButtonClick(TabView sender, object args)
        {
            sender.TabItems.Add(CreateNewTab(sender.TabItems.Count));
        }

        private void TabView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            sender.TabItems.Remove(args.Tab);
        }

        private TabViewItem CreateNewTab(int index)
        {
            TabViewItem newItem = new TabViewItem();

            newItem.Header = $"Document {index}";
            newItem.IconSource = new Microsoft.UI.Xaml.Controls.SymbolIconSource() { Symbol = Symbol.Document };

            // The content of the tab is often a frame that contains a page, though it could be any UIElement.
            Frame frame = new Frame();

            switch (index % 3)
            {
                case 0:
                    //frame.Navigate(typeof(SamplePage1));
                    break;
                case 1:
                    //frame.Navigate(typeof(SamplePage2));
                    break;
                case 2:
                    //frame.Navigate(typeof(SamplePage3));
                    break;
            }

            newItem.Content = frame;

            return newItem;
        }
    }
}
