using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnglishApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainBeginnerGrid : ContentPage
    {
        public MainBeginnerGrid()
        {
            InitializeComponent();
        }

        private async void Click_Lesson(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id;
            string resultString = string.Join(string.Empty, Regex.Matches(button.ImageSource.ToString(), @"\d+").OfType<Match>().Select(m => m.Value));
            int.TryParse(resultString, out id);
            LessonPage lesson = new LessonPage(id);
            await Navigation.PushAsync(lesson);
        }
    }
}