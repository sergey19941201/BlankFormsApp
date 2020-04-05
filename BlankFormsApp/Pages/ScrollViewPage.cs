using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class ScrollViewPage : ContentPage
    {
        public ScrollViewPage()
        {
            StackLayout stackLayout = new StackLayout();
            for (int i = 1; i < 40; i++)
            {
                Label label = new Label
                {
                    Text = "Метка " + i,
                    FontSize = 23
                };
                stackLayout.Children.Add(label);
            }
            ScrollView scrollView = new ScrollView();

            stackLayout.Orientation = StackOrientation.Horizontal;
            scrollView.Orientation = ScrollOrientation.Horizontal;

            scrollView.Content = stackLayout;
            Content = scrollView;
        }
    }
}

