using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ComboBoxFlyoutPage : Page
    {
        private Flyout flyout;

        public ComboBoxFlyoutPage(Flyout flyout)
        {
            this.InitializeComponent();
            this.flyout = flyout;
            loadSettings();
        }

        private void loadSettings()
        {
            descriptionTextBlock.Text = @"
If you click on the comboBox first, it will 
open as expected.

If you click outside the comboBox and then 
click on the comboBox, the flyout will close.
";

            for (int i = 1; i < 4; i++)
            {
                optionsComboBox.Items.Add("Option " + i.ToString());
            }

            optionsComboBox.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            flyout.Hide();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            flyout.Hide();
        }
    }
}
