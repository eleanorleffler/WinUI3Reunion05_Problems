using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HyperlinksPage : Page
    {
        public HyperlinksPage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
            issueTextBlock.Text = @"
Issue #3. Hyperlink with ""mailto:"" doesn't work

The hyperlink to a website works (opens website in browser window), 
but the hyperlink with mailto: does not pull up your e-mail application, 
as it does in UWP.
";
        }

    }
}
