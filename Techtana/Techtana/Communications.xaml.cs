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

namespace Techtana
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Communications : Page
    {
        public Communications()
        {
            this.InitializeComponent();
            Guide.Navigate(typeof(CommRequest));
            Guide2.Navigate(typeof(CommManage));
        }

        private void RequestButton_Click(object sender, RoutedEventArgs e)
        {
            Guide.Navigate(typeof(CommRequest));

            if (Guide.Visibility == Visibility.Collapsed)

            {
                Guide.Visibility = Visibility.Visible;
                Guide2.Visibility = Visibility.Collapsed;


            }

            else if (Guide.Visibility == Visibility.Visible)

            {
                Guide.Visibility = Visibility.Collapsed;
            }
        }

        private void ManageButton_Click(object sender, RoutedEventArgs e)
        {
            Guide2.Navigate(typeof(CommManage));

            if (Guide2.Visibility == Visibility.Collapsed)

            {
                Guide2.Visibility = Visibility.Visible;
                Guide.Visibility = Visibility.Collapsed;
                
                
            }

            else if (Guide2.Visibility == Visibility.Visible)

            {
                Guide2.Visibility = Visibility.Collapsed;
            }
        }
    }
}
