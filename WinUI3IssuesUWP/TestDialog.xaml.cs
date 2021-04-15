using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinUI3IssuesUWP
{
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
