using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankFormsApp.Entities;
using BlankFormsApp.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroupingPage : ContentPage
    {
        // список групп, к которым идет привязка
        public ObservableCollection<Grouping<string, Phone>> PhoneGroups { get; set; }
        public ListViewGroupingPage()
        {
            InitializeComponent();
            
            // начальные данные
            var phones = new List<Phone>
            {
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 },
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 }, 
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 },
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 }, 
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 },
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 }, 
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 },
                new Phone {Title="Galaxy S8", Company="Samsung", Price=60000 },
                new Phone {Title="Galaxy S7 Edge", Company="Samsung", Price=50000 },
                new Phone {Title="Huawei P10", Company="Huawei", Price=10000 },
                new Phone {Title="Huawe Mate 8", Company="Huawei", Price=29000 },
                new Phone {Title="Mi6", Company="Xiaomi", Price=55000 },
                new Phone {Title="iPhone 7", Company="Apple", Price=38000 },
                new Phone {Title="iPhone 6S", Company="Apple", Price=50000 },
            };
            // получаем группы
            var groups = phones.GroupBy(p => p.Company).Select(g => new Grouping<string, Phone>(g.Key, g));
            // передаем группы в PhoneGroups
            PhoneGroups = new ObservableCollection<Grouping<string, Phone>>(groups);
            this.BindingContext = this;
        }
    }
}