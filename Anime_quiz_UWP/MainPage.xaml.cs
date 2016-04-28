using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Anime_quiz_UWP
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested += backButton_Tapped;
        }
        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {

            // insert anything you need to do before navigating

            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }

        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested -= backButton_Tapped;
        }


        private void Level1_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("1");
            this.Frame.Navigate(typeof(Question));
        }

        private void Level2_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("2");
            this.Frame.Navigate(typeof(Question));
        }

        private void Level3_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("3");
            this.Frame.Navigate(typeof(Question));
        }

        private void Level4_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("4");
            this.Frame.Navigate(typeof(Question));

        }

        private void Level5_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("5");
            this.Frame.Navigate(typeof(Question));

        }

        private void Level6_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("6");
            this.Frame.Navigate(typeof(Question));

        }

        private void Level7_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("7");
            this.Frame.Navigate(typeof(Question));

        }
        private void Level8_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("8");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level9_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("9");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level10_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("10");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level11_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("11");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level12_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("12");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level13_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("13");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level14_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("14");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level15_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("15");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level16_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("16");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level17_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("17");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level18_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("18");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level19_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("19");
            this.Frame.Navigate(typeof(Question));
        }
        private void Level20_Click(object sender, RoutedEventArgs e)
        {
            _data level = new _data();
            level.writelevel_number("20");
            this.Frame.Navigate(typeof(Question));
        }
    }
}
