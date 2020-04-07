using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankFormsApp.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataTriggersPage : ContentPage
    {
        public ObservableCollection<Phone> Phones { get; set; }
        public DataTriggersPage()
        {
            InitializeComponent();
            
            Phones = new ObservableCollection<Phone>
            {
                new Phone { Title = "HTC U Ultra", Company = "HTC", Price = 36000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=42000 },
                new Phone {Title="LG G 6", Company="LG", Price=42000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000 }
            };
            this.BindingContext = this;
        }
    }
}