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
    public partial class LessonPage : ContentPage
    {
        public LessonTable table = App.Database.GetItem_LessonTable(1);
        public IEnumerator<PracticeTable> ie = App.Database.GetItem_PracticeTable(1).GetEnumerator();
        public LessonPage()
        {
            InitializeComponent();
            ie.MoveNext();
            description.Text = ie.Current.sentence_ru;
            ans.Text = "Результат";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (ie.Current.sentence_en == input.Text)
            {
                ans.Text = "Правильно!";
                ie.MoveNext();
                if (ie.Current == null)
                {
                    this.Navigation.PopAsync();
                } else
                {
                    description.Text = ie.Current.sentence_ru;
                }
            }
            else
            {
                ans.Text = "Неправильно!";
            }
        }
    }
}