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
        public LessonTable table;
        public IEnumerator<PracticeTable> ie;
        int id_lesson = 0;

        public LessonPage(int _id)
        {
            InitializeComponent();
            this.id_lesson = _id;
            table = App.Database.GetItem_LessonTable(1);
            ie = App.Database.GetItem_PracticeTable(this.id_lesson).GetEnumerator();
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