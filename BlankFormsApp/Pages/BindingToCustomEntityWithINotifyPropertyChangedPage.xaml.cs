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
    public partial class BindingToCustomEntityWithINotifyPropertyChangedPage : ContentPage
    {
        public BindingToCustomEntityWithINotifyPropertyChangedPage()
        {
            InitializeComponent();
        }

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            var phone = this.Resources["phone"] as Phone;
            phone.Price += 4000;
            phone.Company = "custom company";
            phone.Title = "custom title";
        }
    }
}