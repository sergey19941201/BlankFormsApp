using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankFormsApp.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationCommon2Page : ContentPage
    {
        private Phone _phone;
        public NavigationCommon2Page(Phone phone)
        {
            InitializeComponent();

            _phone = phone;
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
            // After pop executed:
            PutDataBackToPreviousPage(navPage);
        }

        private void PutDataBackToPreviousPage(NavigationPage navPage)
        {
             IReadOnlyList<Page> navStack = navPage.Navigation.NavigationStack;
             NavigationCommonPage navigationCommonPage = navStack[navPage.Navigation.NavigationStack.Count - 1] as NavigationCommonPage;
             // Return data to previous page
             navigationCommonPage.PutDataFromAnotherPage("Data from another page");
        }

        private async void PopToRoot(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((NavigationMainPage)navPage.CurrentPage).DisplayStack();
        }
    }
}