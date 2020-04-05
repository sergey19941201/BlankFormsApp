using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class StackLayoutPage : ContentPage
    {
        private StackLayout _stackLayout;

        public StackLayoutPage()
        {
            _stackLayout = new StackLayout()
            {
                Children =
                {
                    new Label() { Text = "Первая метка" },
                    new Label() { Text = "Вторая метка" }
                },
                Spacing = 10
            };

            Content = _stackLayout;

            AddSomething();
        }

        private async void AddSomething()
        {
            await Task.Delay(1000);



            _stackLayout.Children.Add(new Label { Text = "Третья метка" });
        }
    }
}

