using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GridSplitterPage : Page
    {
        public GridSplitterPage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
        issueTextBlock.Text = @"
Issue #5. GridSplitter - Hover Cursor not displayed (requires the public Cursor)

In UWP, the cursor changes when hovering over a GridSplitter. 
In WinUI 3, Reunion 0.5 it doesn't change until you click and drag the GridSplitter.
";
        }
    }
}
