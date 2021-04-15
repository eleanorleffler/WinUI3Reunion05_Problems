using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DialogsAndFlyoutsPage : Page
    {
        public DialogsAndFlyoutsPage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
            issueTextBlock.Text = @"
Issue #2. Flyouts and Content Dialogs - Window Resizing Not Handled

Flyout and Content Dialogs should be aware of the application window size and 
resize and show/hide scrollbars as needed.

In UWP, this works correctly both when a flyout or content dialog is initially 
opened AND when the application window is resized after the flyout or content 
dialog has been opened.

In WinUI 3, Reunion 0.5, this only works when a flyout or content dialog is 
initially opened, but not when the application window is resized after opening.

Click on the Buttons below to see this in action.
";
        }

        private void testFlyout_Opening(object sender, object e)
        {
            textFlyoutText.Text = @"Testing Flyouts with Window Resize:

This is some long text in a flyout
.
.
If the window is not tall enough to fit 
the entire text of the flyout, the flyout 
will be sized to fit the window and show a 
vertical scrollbar.
.
.
When the flyout is initially opened, this 
will work as expected in both UWP and 
WinUI 3, Reunion 0.5.
.
.
When you resize the application window, we 
expect the flyout to accomodate this and 
resize and display a scrollbar when needed 
and remove the scrollbar when no longer needed.
.
.
In UWP, this works as expected.
.
.
In WinUI 3, Reunion 0.5, 
this does not work.
.
.
Test this by resizing the application window 
both before opening this flyout and while
this flyout is open.
.
.
.... End of Flyout Text ....";

        }

        private async void testContentDialog_Click(object sender, RoutedEventArgs e)
        {
            TestDialog dialog = new TestDialog();
            dialog.XamlRoot = this.XamlRoot;
            await dialog.ShowAsync();
        }
    }
}
