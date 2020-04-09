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
    public partial class MVVMContextActionsPhonesListPage : ContentPage
    {
        public MVVMContextActionsPhonesListPage()
        {
            InitializeComponent();
            
            this.BindingContext = new ContextActionsPhonesListViewModel();
        }
    }
}