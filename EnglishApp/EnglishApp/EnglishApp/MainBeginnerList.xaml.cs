using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnglishApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainBeginnerList : ContentPage
    {
        public MainBeginnerList()
        {
            InitializeComponent();
        }

        private async void Click_Lesson(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var giud = button.Id;
            string guid = button.Id.ToString();
            int id;
            string resultString = string.Join(string.Empty, Regex.Matches(button.ImageSource.ToString(), @"\d+").OfType<Match>().Select(m => m.Value));
            int.TryParse(resultString, out id);
            LessonPage lesson = new LessonPage(id);
            await Navigation.PushAsync(lesson);
        }
    }
}