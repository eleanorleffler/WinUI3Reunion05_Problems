using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Storage;
using Windows.Storage.Pickers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinUI3IssuesUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FileOpenPickerPage : Page
    {
        public FileOpenPickerPage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
            issueTextBlock.Text = @"
Issue #6. FileOpenPicker - PickMultipleFilesAsync crashes application

In UWP, the FileOpenPicker works for both PickSingleFileAsync and PickMultipleFilesAsync.

In WinUI 3, Reunion 0.5 PickSingleFileAsync works, but PickMultipleFilesAsync causes a crash.
";
        }

        private async void fileOpenPickerSingleButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new FileOpenPicker();
            picker.ViewMode = PickerViewMode.List;
            picker.SuggestedStartLocation = PickerLocationId.Desktop;
            picker.FileTypeFilter.Add(".txt");

            StorageFile storageFile = await picker.PickSingleFileAsync();
            string text = string.Empty;
            if (storageFile != null)
            {
                text += storageFile.Path + Environment.NewLine;
            }
            fileOpenPickerSingleTextBlock.Text = text;
        }

        private async void fileOpenPickerMultipleButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new FileOpenPicker();
            picker.ViewMode = PickerViewMode.List;
            picker.SuggestedStartLocation = PickerLocationId.Desktop;
            picker.FileTypeFilter.Add(".txt");

            IReadOnlyList<StorageFile> filesToOpen = await picker.PickMultipleFilesAsync();
            string text = string.Empty;
            foreach (StorageFile storageFile in filesToOpen)
            {
                text += storageFile.Path + Environment.NewLine;
            }
            fileOpenPickerMultipleTextBlock.Text = text;
        }

    }
}
