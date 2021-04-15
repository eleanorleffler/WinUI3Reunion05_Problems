using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinUI3IssuesUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
            summaryTextBlock.Text = @"
This solution contains descriptions and examples of all of the
issues we have found with WinUI 3, Reunion 0.5.

Each NavigationView item presents a different issue.
Select each item in turn to view all of the issues.";

            issueTextBlock.Text = @"
Issue #1. Navigation View - Settings Button has ScrollViewer

When you hover over the right-hand side of the Settings Button at the bottom 
of this NavigationView (WinUI 3, Reunion 0.5), scrollbars will appear.

The scrollbars are certainly not necessary.

In UWP, the scrollbars do not appear.

It seems this behavior was introduced when the NavigationFooterItems
were added to NavigationView.
";
        }
    }
}
