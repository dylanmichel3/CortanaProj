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
using Windows.System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Techtana
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }

        private async void Button_Click_MyTech(object sender, RoutedEventArgs e)
        {
            Uri website = new Uri(@"https://ge.service-now.com/mytech");
            await Launcher.LaunchUriAsync(website);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (B1.Visibility == Visibility.Collapsed)

            {
                B1.Visibility = Visibility.Visible;
                B2.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
               
            }

            else if (B1.Visibility == Visibility.Visible)

            {
                B1.Visibility = Visibility.Collapsed;
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (B2.Visibility == Visibility.Collapsed)

            {
                B2.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
                
            }

            else if (B2.Visibility == Visibility.Visible)

            {
                B2.Visibility = Visibility.Collapsed;
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            if (B3.Visibility == Visibility.Collapsed)

            {
                B3.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B2.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
                
            }

            else if (B3.Visibility == Visibility.Visible)

            {
                B3.Visibility = Visibility.Collapsed;
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            if (B4.Visibility == Visibility.Collapsed)

            {
                B4.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B2.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
                
            }

            else if (B4.Visibility == Visibility.Visible)

            {
                B4.Visibility = Visibility.Collapsed;
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            if (B5.Visibility == Visibility.Collapsed)
            {
                B5.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B2.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
                
            }

            else if (B5.Visibility == Visibility.Visible)

            {
                B5.Visibility = Visibility.Collapsed;
            }

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            if (B6.Visibility == Visibility.Collapsed)
            {
                B6.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B2.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
                
            }

            else if (B6.Visibility == Visibility.Visible)

            {
                B6.Visibility = Visibility.Collapsed;
            }

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            if (B7.Visibility == Visibility.Collapsed)
            {
                B7.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B2.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
                
            }

            else if (B7.Visibility == Visibility.Visible)

            {
                B7.Visibility = Visibility.Collapsed;
            }

        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

            if (B8.Visibility == Visibility.Collapsed)
            {
                B8.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B2.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B9.Visibility = Visibility.Collapsed;
                
            }

            else if (B8.Visibility == Visibility.Visible)

            {
                B8.Visibility = Visibility.Collapsed;
            }

        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

            if (B9.Visibility == Visibility.Collapsed)
            {
                B9.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Collapsed;
                B2.Visibility = Visibility.Collapsed;
                B3.Visibility = Visibility.Collapsed;
                B4.Visibility = Visibility.Collapsed;
                B5.Visibility = Visibility.Collapsed;
                B6.Visibility = Visibility.Collapsed;
                B7.Visibility = Visibility.Collapsed;
                B8.Visibility = Visibility.Collapsed;
                
            }

            else if (B9.Visibility == Visibility.Visible)

            {
                B9.Visibility = Visibility.Collapsed;
            }

        }
    }
}
