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
    public partial class NavigationCommonPage : ContentPage
    {
        public NavigationCommonPage()
        {
            InitializeComponent();
        }
        
        // Переход вперед на Page3
        private async void GoToForward(object sender, EventArgs e)
        {
            NavigationCommon2Page page = new NavigationCommon2Page();
            await Navigation.PushAsync(page);
            page.DisplayStack();
        }

        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((NavigationMainPage)navPage.CurrentPage).DisplayStack();
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
    }
}