using Xamarin.Forms;

namespace BlankFormsApp.Views
{
    public class TextSizedLabel : Label
    {
        public static readonly BindableProperty MyTextSizeProperty =
            BindableProperty.Create("MyTextSize", typeof(int), typeof(HeaderView), 12);

        public int MyTextSize
        {
            set { SetValue(MyTextSizeProperty, value); }
            get { return (int) GetValue(MyTextSizeProperty); }
        }
    }
}