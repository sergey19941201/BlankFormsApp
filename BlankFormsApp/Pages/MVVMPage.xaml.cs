using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankFormsApp.MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MVVMPage : ContentPage
    {
        public MVVMPage()
        {
            InitializeComponent();

            this.BindingContext = new PhoneViewModel
            {
                Title = "iPhone 7",
                Company = "Apple",
                Price = 50000
            };
        }
    }
}