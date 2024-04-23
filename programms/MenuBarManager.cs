using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT.Interop;

namespace One_Lesson
{
    public sealed partial class MainWindow : Window
    {
        private async void MenuSaveButtonClick(object sender, RoutedEventArgs e)
        {
            var savePicker = new FileSavePicker();
            // Get the App.Window that i seeked for soo long!
            var window = App.mainWindow;
            // Get the window handle
            var hWnd = WindowNative.GetWindowHandle(window);
            // Initialize the file picker with the window handle (HWND).
            InitializeWithWindow.Initialize(savePicker, hWnd);

            // Set options for your file picker
            savePicker.SuggestedStartLocation = PickerLocationId.Desktop;
            savePicker.DefaultFileExtension = ".olf";
            savePicker.SuggestedFileName = "document.olf";
            savePicker.FileTypeChoices.Add("OneLesson file", new List<string> { ".olf" });
            savePicker.FileTypeChoices.Add("Raw text file", new List<string> { ".rtf" });
            savePicker.FileTypeChoices.Add("All files", new List<string> { "." });


            // Open the picker for the user to pick a file
            var path = await savePicker.PickSaveFileAsync();
            if (path != null)
            {
                if (path.FileType == ".olf" || path.FileType == ".rtf")
                {
                    CachedFileManager.DeferUpdates(path);
                    Windows.Storage.Streams.IRandomAccessStream stream = await path.OpenAsync(FileAccessMode.ReadWrite);
                    DocumentContent.Document.SaveToStream(TextGetOptions.FormatRtf, stream);
                    Windows.Storage.Provider.FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(path);
                    if (status != Windows.Storage.Provider.FileUpdateStatus.Complete)
                    { InfoBarMessage("File " + path.Name + " couldn't be saved.", "Check if your file is used by another application and retry.", InfoBarSeverity.Error); }
                    else
                    { InfoBarMessage("File saved!", "saved", InfoBarSeverity.Success); }
                    string mycontent;
                    DocumentContent.Document.GetText(TextGetOptions.None, out mycontent);
                    DocumentContent.PlaceholderText = mycontent;
                }
            }
        }
        private async void MenuOpenButtonClick(object sender, RoutedEventArgs e)
        {
            var openPicker = new FileOpenPicker();
            // Get the App.Window that i seeked for soo long!
            var window = App.mainWindow;
            // Get the window handle
            var hWnd = WindowNative.GetWindowHandle(window);
            // Initialize the file picker with the window handle (HWND).
            InitializeWithWindow.Initialize(openPicker, hWnd);

            // Set options for your file picker
            openPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            openPicker.FileTypeFilter.Add("*");
            openPicker.FileTypeFilter.Add(".olf");


            // Open the picker for the user to pick a file
            var path = await openPicker.PickSingleFileAsync();
            OpenFile(path);
        }
    }
}