using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FlyoutComboBoxPage : Page
    {
        public FlyoutComboBoxPage()
        {
            this.InitializeComponent();
            setText();
        }

        private void setText()
        {
            issueTextBlock.Text = @"
Issue #9. Flyout Closes when Combo Box clicked

This is the same problem in UWP and WinUI 3, Reunion 0.5.

If you have a flyout with a comboBox, clicking on the comboBox
first will open the comboBox as expected. 

Clicking somewhere on the flyout and then clicking on the comboBox 
will close the flyout, which is not the desired behavior.
";
        }

        private void createFlyout(object sender, string maxHeight, string maxWidth)
        {
            Flyout f = sender as Flyout;
            Style s = new Style { TargetType = typeof(FlyoutPresenter) };
            s.Setters.Add(new Setter(MaxHeightProperty, maxHeight));
            s.Setters.Add(new Setter(MaxWidthProperty, maxWidth));
            f.FlyoutPresenterStyle = s;
        }

        private void comboBoxFlyout_Opening(object sender, object e)
        {
            createFlyout(sender, "400", "430");
            setFlyoutContent();
        }

        private void setFlyoutContent()
        {
            comboBoxFlyoutGrid.Children.Clear();
            ComboBoxFlyoutPage page = new ComboBoxFlyoutPage(comboBoxFlyout);
            comboBoxFlyoutGrid.Children.Add(page);
        }
    }
}
