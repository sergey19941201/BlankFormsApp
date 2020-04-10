using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BlankFormsApp.Localization;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalizationPage : ContentPage
    {
        public LocalizationPage()
        {
            InitializeComponent();
            
            MyLabel.Text = AppResources.FillForm;
            MyEntry.Placeholder = AppResources.EnterLogin;
            MyButton.Text = AppResources.Save;
        }
    }
}