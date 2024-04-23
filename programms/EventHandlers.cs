/*
Contains all the functions that are going to be called by events.
*/

namespace One_Lesson
{
    public sealed partial class MainWindow : Window
    {
        // Info bar
        private void InfoBarCloseButtonClicked(object sender, object args)
        {
            DocumentContent.Height = DocumentContent.ActualHeight + InfoBar.ActualHeight;
        }

        // Title button
        private void TitleButton_click(object sender, RoutedEventArgs e)
        {
            ITextSelection selectedText = DocumentContent.Document.Selection;
            if (selectedText != null)
            {
                if (selectedText.CharacterFormat.Size == 24)
                {
                    selectedText.CharacterFormat.Bold = FormatEffect.Off;
                    selectedText.CharacterFormat.Size = 12;
                }
                else
                {
                    selectedText.CharacterFormat.Bold = FormatEffect.On;
                    selectedText.CharacterFormat.Size = 24;
                }
            }
        }

        // Command bar
        private void Menu_Opening(object sender, object e)
        {
            CommandBarFlyout contextMenuFlyout = sender as CommandBarFlyout;
            if (contextMenuFlyout.Target == DocumentContent)
            {
                AppBarButton shareButton = new()
                {
                    Command = new StandardUICommand(StandardUICommandKind.Share)
                };
                AppBarButton setTitleButton = new()
                {
                    Label = "Title",
                    Icon = new FontIcon()
                    {
                        Glyph = "T",
                        FontSize = 16,
                        FontFamily = new FontFamily("Candara")
                    }
                };
                setTitleButton.Click += TitleButton_click;
                AppBarButton setSizeButton = new()
                {
                    Label = "Set Size",
                    Icon = new FontIcon()
                    {
                        Glyph = "^",
                        FontSize = 16
                    }
                };
                contextMenuFlyout.PrimaryCommands.Add(shareButton);
                contextMenuFlyout.PrimaryCommands.Add(setTitleButton);
                contextMenuFlyout.PrimaryCommands.Add(setSizeButton);
            }
        }

        // Rich edit box (document content)
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
    }
}