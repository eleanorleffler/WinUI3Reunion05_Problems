using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestDialog : ContentDialog
    {
        public TestDialog()
        {
            this.InitializeComponent();
            loadSettings();
        }

        private void loadSettings()
        {
            descriptionTextBlock.Text = @"If the window is not tall enough to fit all the items, the dialog will
be sized to show a vertical scrollbar, with the buttons visible.

When the dialog is initially opened, this will work as expected in both UWP 
and WinUI 3, Reunion 0.5.

When you resize the application window, we expect the dialog to resize and 
display a scrollbar on the list when needed, keeping the buttons visible.

In UWP, this works as expected. In WinUI 3, Reunion 0.5, this does not work.
Test this by resizing the application window both before opening this dialog
and while this dialog is open.";

            for (int i = 1; i < 10; i++)
            {
                itemListView.Items.Add("Item " + i.ToString());
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
