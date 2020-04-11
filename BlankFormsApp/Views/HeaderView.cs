using Xamarin.Forms;

namespace BlankFormsApp.Views
{
    public class HeaderView : View
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(HeaderView), string.Empty);

        public string Text
        {
            set { SetValue(TextProperty, value); }
            get { return (string) GetValue(TextProperty); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create("TextColor", typeof(Color), typeof(HeaderView), Color.Default);

        public Color TextColor
        {
            set { SetValue(TextColorProperty, value); }
            get { return (Color) GetValue(TextColorProperty); }
        }
    }
}