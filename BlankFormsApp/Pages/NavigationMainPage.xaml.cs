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
    public partial class NavigationMainPage : ContentPage
    {
        public NavigationMainPage()
        {
            InitializeComponent();
        }

        private async void ToModalPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationModalPage());
        }

        private async void ToCommonPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationCommonPage());
        }
    }
}