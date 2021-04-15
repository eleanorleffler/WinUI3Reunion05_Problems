using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinUI3IssuesUWP
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
