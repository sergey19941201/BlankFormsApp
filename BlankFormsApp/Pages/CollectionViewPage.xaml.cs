using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankFormsApp.Cells;
using BlankFormsApp.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewPage : ContentPage
    {
        public ObservableCollection<Phone> CollectionSource { get; set; }

        public CollectionViewPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            CollectionSource = await GetItemsFromService();

            // IMPORTANT!!! HERE AFTER AWAIT
            this.BindingContext = this;

            // HACK To properly update auto-height item depending on text height ios
            CollectionSource.Add(null);
            CollectionSource.RemoveAt(CollectionSource.Count - 1);

            await Task.Delay(1000);

            AddSomeItems();
        }

        private async Task<ObservableCollection<Phone>> GetItemsFromService()
        {
            await Task.Delay(2000);

            return new ObservableCollection<Phone>
            {
                new Phone
                {
                    Title =
                        "Galaxy S8Galaxy S8Galaxy S8Galaxy S8Galaxy S8Galaxy S8Galaxy S8Galaxy S8Galaxy S8Galaxy S8Galaxy S8",
                    ImagePath = "https://i.ytimg.com/vi/Ekb_I21Gssc/maxresdefault.jpg"
                },
                new Phone {Title = "Huawei P10", ImagePath = "gorilla.png"},
                new Phone {Title = "HTC U Ultra", ImagePath = "monkey_circle.png"},
                new Phone {Title = "iPhone 7", ImagePath = "gorilla.png"}
            };
        }

        private void AddSomeItems()
        {
            for (int i = 0; i < 100; i++)
            {
                CollectionSource.Add(new Phone
                {
                    Title = i.ToString(),
                    ImagePath = "https://i.ytimg.com/vi/Ekb_I21Gssc/maxresdefault.jpg"
                });
            }
        }
    }
}