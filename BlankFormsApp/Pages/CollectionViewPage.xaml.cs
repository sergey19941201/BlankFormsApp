using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewPage : ContentPage
    {
        public ObservableCollection<string> CollectionSource { get; set; }

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
            
            await Task.Delay(1000);
            AddSomeItems();
        }

        private async Task<ObservableCollection<string>> GetItemsFromService()
        {
            await Task.Delay(2000);
            
            return new ObservableCollection<string>
            {
                "gjgjjg",
                "fddf",
                "Bdffddf",
                "Squdffdy",
                "Godfin",
                "Hfd",
                "Japdf"
            };
        }

        private void AddSomeItems()
        {
            CollectionSource.Add("gjjgjggggggggggggggg");
            CollectionSource.Add("gjjgjggggggggggggggg");
            CollectionSource.Add("gjjgjggggggggggggggg");
        }
    }
}