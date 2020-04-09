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
    public partial class MVVMFriendsListPage : ContentPage
    {
        public MVVMFriendsListPage()
        {
            InitializeComponent();
            
            BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
        }
    }
}