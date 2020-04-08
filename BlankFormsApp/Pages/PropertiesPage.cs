using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class PropertiesPage : ContentPage
    {
        public PropertiesPage()
        {
            AddProperties();
        }

        private async void AddProperties()
        {
            object name;
            if (App.Current.Properties.TryGetValue("name", out name))
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