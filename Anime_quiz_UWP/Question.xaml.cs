using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Anime_quiz_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class Question : Page
    {
        public string level_number;
        public string answer;
        public Question()
        {
            this.InitializeComponent();
            _data question_data = new _data();
            level_number = question_data.readdata("Level_number").ToString();
            QuestionText.Text = question_data.readdata("Question_" + level_number).ToString(); // judul pertanyaan
            BitmapImage bitmapImage = new BitmapImage(new Uri("ms-appx://Anime_quiz_UWP/Assets/" + level_number + ".jpg"));
            image_chara.Source = bitmapImage; // ganti gambar
            Text_.Text = question_data.readdata("QuestionQuestion_" + level_number).ToString();
            answer = question_data.readdata("QuestionAnswer_" + level_number).ToString();
            TheAnswer.Text = answer;
            if (question_data.readdata("QuestionDone_" + level_number).ToString() == "true")
            {
                TheAnswer.Visibility = Visibility;
                AnswerPlayer.IsEnabled = false;
                answbutton.IsEnabled = false;
            }
            else
            {
                AnswerPlayer.IsEnabled = true;
                answbutton.IsEnabled = true;
            }


        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.VirtualKey == VirtualKey.Enter)
            {
                jawab();
            }
        }
        private void answbutton_Click(object sender, RoutedEventArgs e)
        {
            _data question_data = new _data();
            //nanti pke edit distance
            int beda = edit_distance(answer.ToLower(), AnswerPlayer.Text.Trim().ToLower());
            if (beda == 0)
            {
                //kasi bener
                TheAnswer.Visibility = Visibility;
                The1.Visibility = Visibility;
                The.Visibility = Visibility.Collapsed;
                The2.Visibility = Visibility.Collapsed;
                question_data.writesuccess(level_number);
            }
            else if (beda < 3)
            {
                //hampir bener
                The2.Visibility = Visibility;
                The1.Visibility = Visibility.Collapsed;
                The.Visibility = Visibility.Collapsed;
            }
            else
            {
                The.Visibility = Visibility;
                The1.Visibility = Visibility.Collapsed;
                The2.Visibility = Visibility.Collapsed;
            }


        }
        public void jawab() //bisa enter ? kalau gk bsa akses button klik
        {
            //nanti pke edit distance
            if (answer == AnswerPlayer.Text.Trim())
            {
                //kasi bener
                TheAnswer.Visibility = Visibility;
                The1.Visibility = Visibility;
                The.Visibility = Visibility.Collapsed;
                The2.Visibility = Visibility.Collapsed;
            }
            else
            {
                The.Visibility = Visibility;
                The1.Visibility = Visibility.Collapsed;
                The2.Visibility = Visibility.Collapsed;
            }
        }

        public static int edit_distance(string kata1, string kata2)
        {
            // sumber : http://www.dotnetperls.com/

            int asli = kata1.Length;
            int banding = kata2.Length;
            int[,] toleransi = new int[asli + 1, banding + 1];

            // Step 1
            if (asli == 0)
            {
                return banding;
            }

            if (banding == 0)
            {
                return asli;
            }

            // Step 2
            for (int i = 0; i <= asli; toleransi[i, 0] = i++)
            {
            }

            for (int j = 0; j <= banding; toleransi[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= asli; i++)
            {
                //Step 4
                for (int j = 1; j <= banding; j++)
                {
                    // Step 5
                    int cost = (kata2[j - 1] == kata1[i - 1]) ? 0 : 1;

                    // Step 6
                    toleransi[i, j] = Math.Min(
                        Math.Min(toleransi[i - 1, j] + 1, toleransi[i, j - 1] + 1),
                        toleransi[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return toleransi[asli, banding];
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

    }
}
