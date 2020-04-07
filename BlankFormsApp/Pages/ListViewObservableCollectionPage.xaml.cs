using System;
using System.Collections.ObjectModel;
using BlankFormsApp.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewObservableCollectionPage : ContentPage
    {
        public ObservableCollection<Phone> Phones { get; set; }

        public ListViewObservableCollectionPage()
        {
            InitializeComponent();

            Phones = new ObservableCollection<Phone>
            {
                new Phone {Title = "HTC U Ultra", Company = "HTC", Price = 36000},
                new Phone {Title = "Huawei P10", Company = "Huawei", Price = 35000},
                new Phone {Title = "LG G 6", Company = "LG", Price = 42000},
                new Phone {Title = "iPhone 7", Company = "Apple", Price = 52000}
            };
            this.BindingContext = this;
        }

        // добавление объекта
        private void AddItem(object sender, EventArgs e)
        {
            Phones.Add(new Phone {Title = "Galaxy S8", Company = "Samsung", Price = 48000});
        }

        // удаление выделенного объекта
        private void RemoveItem(object sender, EventArgs e)
        {
            Phone phone = phonesList.SelectedItem as Phone;
            if (phone != null)
            {
                Phones.Remove(phone);
                phonesList.SelectedItem = null;
            }
        }
    }
}