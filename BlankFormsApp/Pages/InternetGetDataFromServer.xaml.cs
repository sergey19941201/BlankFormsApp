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
    public partial class InternetGetDataFromServer : ContentPage
    {
        RateViewModel viewModel;
        
        public InternetGetDataFromServer()
        {
            InitializeComponent();
            
            viewModel = new RateViewModel();
            // установка контекста данных
            this.BindingContext = viewModel;
        }
    }
}