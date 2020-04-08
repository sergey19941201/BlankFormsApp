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
        bool loaded = false;
        public NavigationMainPage()
        {
            InitializeComponent();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(loaded==false)
            {
                DisplayStack();
                loaded = true;
            }
        }
        
        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            StackLabel.Text = "";
            foreach (Page p in navPage.Navigation.NavigationStack)
            {
                StackLabel.Text += p.Title + "\n";
            }
        }

        private async void ToCommonPage(object sender, EventArgs e)
        {
            var page = new NavigationCommonPage();
            await Navigation.PushAsync(page);
            page.DisplayStack();
        }

        private async void ToModalPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationModalPage());
        }
    }
}