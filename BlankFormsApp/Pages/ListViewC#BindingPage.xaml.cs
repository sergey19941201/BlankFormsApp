using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewC_BindingPage : ContentPage
    {
        public string[] Phones { get; set; }

        public ListViewC_BindingPage()
        {
            InitializeComponent();
            Phones = new string[] {"iPhone 8", "Samsung Galaxy S9", "Huawei P10", "LG G6"};
            // Binding will not work without this:
            this.BindingContext = this;
        }

        private void phonesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Check if it is not null because event can fire when we unselect item
            if (e.SelectedItem != null)
            {
                var selectedText = e.SelectedItem.ToString();
            }

            // Remove selection
            ((ListView) sender).SelectedItem = null;
        }

        private void PhonesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var tappedText = e.Item.ToString();
            }

            // Remove selection
            ((ListView) sender).SelectedItem = null;
        }
    }
}