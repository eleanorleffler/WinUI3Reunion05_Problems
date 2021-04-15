using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CursorsPage : Page
    {
        public CursorsPage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
            issueTextBlock.Text = @"
Issue #4. Unable to Set Window Cursor Programmatically

In WinUI 3, Reunion 0.5, there is no way to set the Window Cursor in the code. 
For example, we want to change the cursor to a wait cursor while an action is 
taking place that may take a few moments.

In UWP, this is accomplished with code like this:

    CoreWindow coreWindow = CoreWindow.GetForCurrentThread();
    coreWindow.PointerCursor = new CoreCursor(CoreCursorType.Wait, 1);

In WinUI 3, Reunion 0.5, the PointerCursor property is not available.
";

            githubTextBlock.Text = @"
Text from this link:

      ""In the future we expect to also have a public Cursor property that the app developer can use. 
      So two cursor properties, one public and one protected. If both are set, the public property 
      will override the protected property.

      This isn't a pattern we have today. The proposal here is to name them Cursor (future public property) 
      and ProtectedCursor (protected property in this spec).""
";
        }
    }
}
