using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinUI3IssuesUWP
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
