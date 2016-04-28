using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Anime_quiz_UWP
{
    class _data 
    {
        ApplicationDataContainer LoalData;
        public static string level_number;
        public _data()
        {
            LoalData = ApplicationData.Current.LocalSettings;
        }
        public async void writelevel_number(string level_number)
        {
            LoalData.Values["Level_number"] = level_number;
        }
        public async void kontroldata()
        {
            if ((string)LoalData.Values["Version"] != "V1.1")
            {
                //question 1
                LoalData.Values["Question_1"] = "Question 1";
                LoalData.Values["QuestionQuestion_1"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_1"] = "Natsu Dragneel";
                LoalData.Values["QuestionDone_1"] = "false";

                //question 2
                LoalData.Values["Question_2"] = "Question 2";
                LoalData.Values["QuestionQuestion_2"] = "What is the title of this anime ?";
                LoalData.Values["QuestionAnswer_2"] = "Naruto";
                LoalData.Values["QuestionDone_2"] = "false";

                //question 3
                LoalData.Values["Question_3"] = "Question 3";
                LoalData.Values["QuestionQuestion_3"] = "Who is this man?";
                LoalData.Values["QuestionAnswer_3"] = "Saitama";
                LoalData.Values["QuestionDone_3"] = "false";

                //question 4
                LoalData.Values["Question_4"] = "Question 4";
                LoalData.Values["QuestionQuestion_4"] = "What is the title of this anime?";
                LoalData.Values["QuestionAnswer_4"] = "Bakuman";
                LoalData.Values["QuestionDone_4"] = "false";

                //question 5
                LoalData.Values["Question_5"] = "Question 5";
                LoalData.Values["QuestionQuestion_5"] = "Who is this man?";
                LoalData.Values["QuestionAnswer_5"] = "Allen Walker";
                LoalData.Values["QuestionDone_5"] = "false";

                //question 6
                LoalData.Values["Question_6"] = "Question 6";
                LoalData.Values["QuestionQuestion_6"] = "What the title of this anime?";
                LoalData.Values["QuestionAnswer_6"] = "Lovely Complex";
                LoalData.Values["QuestionDone_6"] = "false";

                //question 7
                LoalData.Values["Question_7"] = "Question 7";
                LoalData.Values["QuestionQuestion_7"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_7"] = "Conan";
                LoalData.Values["QuestionDone_7"] = "false";

                //question 8
                LoalData.Values["Question_8"] = "Question 8";
                LoalData.Values["QuestionQuestion_8"] = "What move is he using?";
                LoalData.Values["QuestionAnswer_8"] = "Kamehameha";
                LoalData.Values["QuestionDone_8"] = "false";

                //question 9
                LoalData.Values["Question_9"] = "Question 9";
                LoalData.Values["QuestionQuestion_9"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_9"] = "Alladin";
                LoalData.Values["QuestionDone_9"] = "false";

                //question 10
                LoalData.Values["Question_10"] = "Question 10";
                LoalData.Values["QuestionQuestion_10"] = "What is her name ?";
                LoalData.Values["QuestionAnswer_10"] = "Celty";
                LoalData.Values["QuestionDone_10"] = "false";

                //question 11
                LoalData.Values["Question_11"] = "Question 11";
                LoalData.Values["QuestionQuestion_11"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_11"] = "Arima Kousei";
                LoalData.Values["QuestionDone_11"] = "false";

                //question 12
                LoalData.Values["Question_12"] = "Question 12";
                LoalData.Values["QuestionQuestion_12"] = "What is her name ?";
                LoalData.Values["QuestionAnswer_12"] = "Tachibana Kanade";
                LoalData.Values["QuestionDone_12"] = "false";

                //question 13
                LoalData.Values["Question_13"] = "Question 13";
                LoalData.Values["QuestionQuestion_13"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_13"] = "Kujo Jotaro";
                LoalData.Values["QuestionDone_13"] = "false";

                //question 14
                LoalData.Values["Question_14"] = "Question 14";
                LoalData.Values["QuestionQuestion_14"] = "What is the title of this anime?";
                LoalData.Values["QuestionAnswer_14"] = "Devil Survivor 2";
                LoalData.Values["QuestionDone_14"] = "false";

                //question 15
                LoalData.Values["Question_15"] = "Question 15";
                LoalData.Values["QuestionQuestion_15"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_15"] = "Testsuya Kuroko";
                LoalData.Values["QuestionDone_15"] = "false";

                //question 16
                LoalData.Values["Question_16"] = "Question 16";
                LoalData.Values["QuestionQuestion_16"] = "What is their pen name ?";
                LoalData.Values["QuestionAnswer_16"] = "Ashiragi Muto";
                LoalData.Values["QuestionDone_16"] = "false";

                //question 17
                LoalData.Values["Question_17"] = "Question 17";
                LoalData.Values["QuestionQuestion_17"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_17"] = "Chopper";
                LoalData.Values["QuestionDone_17"] = "false";

                //question 18
                LoalData.Values["Question_18"] = "Question 18";
                LoalData.Values["QuestionQuestion_18"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_18"] = "Hinata Shoyo";
                LoalData.Values["QuestionDone_18"] = "false";

                //question 19
                LoalData.Values["Question_19"] = "Question 19";
                LoalData.Values["QuestionQuestion_19"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_19"] = "Toramizu Ginta";
                LoalData.Values["QuestionDone_19"] = "false";

                //question 20
                LoalData.Values["Question_20"] = "Question 20";
                LoalData.Values["QuestionQuestion_20"] = "What is his name ?";
                LoalData.Values["QuestionAnswer_20"] = "Kuro";
                LoalData.Values["QuestionDone_20"] = "false";

                //untuk gk nulis berulang
                LoalData.Values["Version"] = "V1.0";
            }
        }
       public async void writesuccess(string teks)
        {
             
            LoalData.Values["QuestionDone_"+teks] = "true";
        }
        public string readdata(string data_yang_dibaca)
        {
            string read_data = LoalData.Values[data_yang_dibaca].ToString();
            return read_data;
        }
    }
   
}
