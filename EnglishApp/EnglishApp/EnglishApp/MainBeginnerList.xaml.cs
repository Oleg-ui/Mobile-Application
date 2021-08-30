using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            LessonPage lesson = new LessonPage();
            await Navigation.PushAsync(lesson);
        }
    }
}