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
    public partial class NavigationCommon2Page : ContentPage
    {
        public NavigationCommon2Page()
        {
            InitializeComponent();
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
        
        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
 
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((NavigationCommonPage)navPage.CurrentPage).DisplayStack();
        }
        
        private async void PopToRoot(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((NavigationMainPage)navPage.CurrentPage).DisplayStack();
        }
    }
}