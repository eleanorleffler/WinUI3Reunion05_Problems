using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinUI3IssuesUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CommandBarFlyoutPage : Page
    {
        public CommandBarFlyoutPage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
            issueTextBlock.Text = @"
Issue #8. CommandBar with AppBarButton with Flyout displays "">"" symbol

In WinUI 3, Reunion 0.5, the AppBarButton with a flyout (Open icon) displays
the "">"" symbol, which does not match the look of the other buttons.

In UWP, the AppBarButton with a flyout (Open icon) does not display the 
"">"" symbol.
";
        }
    }
}
