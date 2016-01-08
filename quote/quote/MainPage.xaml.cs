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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace quote
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public MainPage(Frame frame)
        {
            this.InitializeComponent(); 
            MySplitView.Content = frame;
            (MySplitView.Content as Frame).Navigate(typeof(homePage));
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2), "param");
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            (MySplitView.Content as Frame).Navigate(typeof(homePage));
        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {

            (MySplitView.Content as Frame).Navigate(typeof(Page2));


        }
    }
}
