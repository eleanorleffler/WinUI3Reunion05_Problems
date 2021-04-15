using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SetTitleBarPage : Page
    {
        private MainPage mainPage;

        public SetTitleBarPage(MainPage mainPage)
        {
            this.InitializeComponent();
            this.mainPage = mainPage;
            setText();
        }

        private void setText()
        {
            issueTextBlock.Text = @"
Issue #7. Using ""ExtendsContentIntoTitleBar"" with Background Color Hides Min/Max/Close Buttons

In WinUI 3, Reunion 0.5, using ""ExtendsContentIntoTitleBar"" when the background is set on the 
control to be used as the title bar results in the standard action buttons on the window 
(minimize, maximize, close) being hidden.

Additionally, the action buttons are a smaller height when ""ExtendsContentIntoTitleBar"" is used.

In UWP, this was accomplished with code like this:

    CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
    mainWindow.SetTitleBar(AppTitleBarColor);
";

            colorCodeTextBlock.Text = @"
    mainWindow.ExtendsContentIntoTitleBar = true;
    mainWindow.SetTitleBar(AppTitleBarColor);
";
            noColorCodeTextBlock.Text = @"
    mainWindow.ExtendsContentIntoTitleBar = true;
    mainWindow.SetTitleBar(AppTitleBarNoColor);
";
            offCodeTextBlock.Text = @"
    mainWindow.ExtendsContentIntoTitleBar = false;
    mainWindow.SetTitleBar(null);
";
        }

        private void colorButton_Click(object sender, RoutedEventArgs e)
        {
            mainPage.SetTitleBar("Color");
        }

        private void defaultButton_Click(object sender, RoutedEventArgs e)
        {
            mainPage.SetTitleBar("NoColor");
        }

        private void offButton_Click(object sender, RoutedEventArgs e)
        {
            mainPage.SetTitleBar("Off");
        }
    }
}
