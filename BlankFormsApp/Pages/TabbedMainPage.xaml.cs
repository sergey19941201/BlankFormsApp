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
    public partial class TabbedMainPage : TabbedPage
    {
        public TabbedMainPage()
        {
            InitializeComponent();

            AddProperties();
        }

        private async void AddProperties()
        {
            object name;
            if(App.Current.Properties.TryGetValue("name", out name))
            {
                // выполняем действия, если в словаре есть ключ "name"
            }
            else
            {
                name = "Tom";
                App.Current.Properties.Add("name", name);
                await App.Current.SavePropertiesAsync();
            }
        }
    }
}