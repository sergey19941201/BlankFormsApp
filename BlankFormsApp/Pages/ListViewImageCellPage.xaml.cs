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
    public partial class ListViewImageCellPage : ContentPage
    {
        public List<Phone> Phones { get; set; }
        public ListViewImageCellPage()
        {
            InitializeComponent();
            
            Phones = new List<Phone>
            {
                new Phone {Title="Galaxy S8", Company="Samsung", Price=48000, ImagePath="BlankFormsApp.Images.gorilla_core.jpg" },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000, ImagePath="gorilla.png" },
                new Phone {Title="HP Elite z3", Company="HP", Price=42000, ImagePath="gorilla.png" },
                new Phone {Title="LG G 6", Company="LG", Price=42000, ImagePath="gorilla_core.png" },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000, ImagePath="gorilla.png" }
            };
            this.BindingContext = this;
        }
    }
}