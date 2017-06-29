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

namespace Techtana
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        public MainPage()
        {
            this.InitializeComponent();
            Guide.Navigate(typeof(Home));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Guide.Navigate(typeof(Home));
        }

        private void CommButton_Click(object sender, RoutedEventArgs e)
        {
            Guide.Navigate(typeof(Communications));
        }

        private void CompButton_Click(object sender, RoutedEventArgs e)
        {
           Guide.Navigate(typeof(Computers));
        }

        private void ConnButton_Click(object sender, RoutedEventArgs e)
        {
            Guide.Navigate(typeof(Connectivity));
        }

        private void SwButton_Click(object sender, RoutedEventArgs e)
        {
            Guide.Navigate(typeof(Software));
        }


    }

}


