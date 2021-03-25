using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace English_to_automatism
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnImageButtonClicked(object sender, EventArgs e)
        {
            string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                "<ContentPage xmlns=\"http://xamarin.com/schemas/2014/forms\"\n" +
                "xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\n" +
                "x:Class=\"HelloApp.MainPage\"\n" +
                "Title=\"Main Page\">\n" +
                "<Label x:Name=\"lbl\" Text=\"XAML in Xamarin\" FontSize=\"36\" />" +
                "</ContentPage>";

            this.LoadFromXaml(pageXAML);
        }

    }
}
