using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomRendererPage : ContentPage
    {
        public CustomRendererPage()
        {
            InitializeComponent();

            SetTextDelayed();
        }

        private async void SetTextDelayed()
        {
            await Task.Delay(3000);

            SimpleHeaderView.Text = "text changed  in runtime";
            ColoredHeaderView.Text = "text changed  in runtime";
            MyTextSizedLabel.MyTextSize = 36;
        }
    }
}