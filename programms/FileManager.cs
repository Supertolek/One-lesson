using Microsoft.UI.Xaml;
using Microsoft.UI.Text;
using Windows.Storage;
using System;

namespace One_Lesson
{
    public sealed partial class MainWindow : Window
    {
        private async void OpenFile(IStorageFile path)
        {
            if (path != null)
            {
                if (path.FileType == ".olf" || path.FileType == ".rtf")
                {
                    CachedFileManager.DeferUpdates(path);
                    Windows.Storage.Streams.IRandomAccessStream stream = await path.OpenAsync(FileAccessMode.ReadWrite);
                    DocumentContent.Document.LoadFromStream(TextSetOptions.FormatRtf, stream);
                    CreateNewTab(TabBar, "salut les mecs", DocumentContent.TextDocument, stream);
                }
            }
        }
    }
}
