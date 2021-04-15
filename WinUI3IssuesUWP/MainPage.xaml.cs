using System.Linq;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WinUI3IssuesUWP
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

        public MainPage()
        {
            this.InitializeComponent();
            this.mainWindow = Window.Current;
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
                CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
                mainWindow.SetTitleBar(AppTitleBarColor);
            }
            else if (mode == "NoColor")
            {
                AppTitleBarColor.Visibility = Visibility.Collapsed;
                AppTitleBarNoColor.Visibility = Visibility.Visible;
                CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
                mainWindow.SetTitleBar(AppTitleBarNoColor);
            }
            else if (mode == "Off")
            {
                AppTitleBarColor.Visibility = Visibility.Collapsed;
                AppTitleBarNoColor.Visibility = Visibility.Collapsed;
                CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = false;
                mainWindow.SetTitleBar(null);
            }
        }
    }
}
