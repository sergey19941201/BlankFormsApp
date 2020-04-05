using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

            BoxView redBox = new BoxView { BackgroundColor = Color.Red };
            BoxView greenBox = new BoxView { BackgroundColor = Color.Green };
            BoxView blueBox = new BoxView { BackgroundColor = Color.Blue };

            AbsoluteLayout.SetLayoutBounds(redBox, new Rectangle(0.1, 0.2, 50, 80));
            // устанавливаем пропорциональные координаты
            AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(greenBox, new Rectangle(1, 0.2, 50, 80));
            AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(blueBox, new Rectangle(0.1, 0.8, 0.2, 0.2));
            // пропорциональные координаты и размеры
            AbsoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.All);

            absoluteLayout.Children.Add(redBox);
            absoluteLayout.Children.Add(greenBox);
            absoluteLayout.Children.Add(blueBox);

            Content = absoluteLayout;
        }
    }
}

