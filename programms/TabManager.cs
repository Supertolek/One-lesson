using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.Storage.Streams;

namespace One_Lesson
{
    public sealed partial class MainWindow : Window
    {
        private void TabView_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.initialFile == null)
            {
                CreateNewTab(sender as TabView, "New Document");
            } else
            {
                CreateNewTab(sender as TabView, "New Document");
            }
        }

        private void TabView_AddButtonClick(TabView sender, object args)
        {
            CreateNewTab(sender, "New Document");
        }

        private void TabView_TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            sender.TabItems.Remove(args.Tab);
        }

        private void TabView_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            // _ = (((sender as TabView).SelectedItem as TabViewItem).Tag as Tab).Document;
        }

        private void CreateNewTab(TabView tabview, string title, RichEditTextDocument document = null, IRandomAccessStream stream = null)
        {
            TabViewItem tabviewitem = new()
            {
                Header = title,
                Tag = new Tab()
                {
                    Title = title,
                    // Document = null,
                    Stream = stream
                },
                IconSource = new SymbolIconSource()
                {
                    Symbol = Symbol.Document
                }
            };
            tabview.TabItems.Add(tabviewitem);
        }
    }
}
