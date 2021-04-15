using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Linq;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3IssuesReunion05
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Window mainWindow;

        private HomePage homePage;
        private DialogsAndFlyoutsPage dialogsAndFlyoutsPage;
        private HyperlinksPage hyperLinksPage;
        private CursorsPage cursorsPage;
        private GridSplitterPage gridSplitterPage;
        private FileOpenPickerPage fileOpenPickerPage;
        private SetTitleBarPage setTitleBarPage;
        private CommandBarFlyoutPage commandBarFlyoutPage;
        private FlyoutComboBoxPage flyoutComboBoxPage;

        public MainPage(Window mainWindow)
        {
            this.InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void mainNavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            homePage = new HomePage();
            dialogsAndFlyoutsPage = new DialogsAndFlyoutsPage();
            hyperLinksPage = new HyperlinksPage();
            cursorsPage = new CursorsPage();
            gridSplitterPage = new GridSplitterPage();
            fileOpenPickerPage = new FileOpenPickerPage();
            setTitleBarPage = new SetTitleBarPage(this);
            commandBarFlyoutPage = new CommandBarFlyoutPage();
            flyoutComboBoxPage = new FlyoutComboBoxPage();

            contentFrame.Content = homePage;
            mainNavigationView.SelectedItem = mainNavigationView.MenuItems.ElementAt(0);
        }

        private void mainNavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                
            }
            else
            {
                string invokedItem = args.InvokedItem.ToString();
                switch (invokedItem)
                {
                    case "Home Page":
                        contentFrame.Content = homePage;
                        break;
                    case "Dialogs and Flyouts":
                        contentFrame.Content = dialogsAndFlyoutsPage;
                        break;
                    case "Hyperlinks":
                        contentFrame.Content = hyperLinksPage;
                        break;
                    case "Cursors":
                        contentFrame.Content = cursorsPage;
                        break;
                    case "Grid Splitter":
                        contentFrame.Content = gridSplitterPage;
                        break;
                    case "FileOpenPicker":
                        contentFrame.Content = fileOpenPickerPage;
                        break;
                    case "SetTitleBar":
                        contentFrame.Content = setTitleBarPage;
                        break;
                    case "CommandBar Flyout":
                        contentFrame.Content = commandBarFlyoutPage;
                        break;
                    case "Flyout ComboBox":
                        contentFrame.Content = flyoutComboBoxPage;
                        break;

                }
            }
        }

        public void SetTitleBar(string mode)
        {
            if (mode == "Color")
            {
                AppTitleBarColor.Visibility = Visibility.Visible;
                AppTitleBarNoColor.Visibility = Visibility.Collapsed;
                mainWindow.ExtendsContentIntoTitleBar = true;
                mainWindow.SetTitleBar(AppTitleBarColor);
            }
            else if (mode == "NoColor")
            {
                AppTitleBarColor.Visibility = Visibility.Collapsed;
                AppTitleBarNoColor.Visibility = Visibility.Visible;
                mainWindow.ExtendsContentIntoTitleBar = true;
                mainWindow.SetTitleBar(AppTitleBarNoColor);
            }
            else if (mode == "Off")
            {
                AppTitleBarColor.Visibility = Visibility.Collapsed;
                AppTitleBarNoColor.Visibility = Visibility.Collapsed;
                mainWindow.ExtendsContentIntoTitleBar = false;
                mainWindow.SetTitleBar(null);
            }
        }

    }
}
