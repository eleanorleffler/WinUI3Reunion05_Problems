using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
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
            FileOpenPicker picker = GetFileOpenPicker();
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
            FileOpenPicker picker = GetFileOpenPicker();
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

        #region Initialize With Window

        public static FileOpenPicker GetFileOpenPicker()
        {
            FileOpenPicker picker = new FileOpenPicker();
            InitializeWithWindow(picker);
            return picker;
        }

        public static FolderPicker GetFolderPicker()
        {
            FolderPicker picker = new FolderPicker();
            InitializeWithWindow(picker);
            return picker;
        }

        public static FileSavePicker GetFileSavePicker()
        {
            FileSavePicker picker = new FileSavePicker();
            InitializeWithWindow(picker);
            return picker;
        }

        public static void InitializeWithWindow(Object obj)
        {
            // When running on win32, FileOpenPicker needs to know the top-level hwnd via IInitializeWithWindow::Initialize.
            if (Window.Current == null)
            {
                IInitializeWithWindow initializeWithWindowWrapper = obj.As<IInitializeWithWindow>();
                IntPtr hwnd = GetActiveWindow();
                initializeWithWindowWrapper.Initialize(hwnd);
            }
        }

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto, PreserveSig = true, SetLastError = false)]
        public static extern IntPtr GetActiveWindow();

        #endregion
    }

    [ComImport, System.Runtime.InteropServices.Guid("3E68D4BD-7135-4D10-8018-9FB6D9F33FA1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInitializeWithWindow
    {
        void Initialize([In] IntPtr hwnd);
    }
}
