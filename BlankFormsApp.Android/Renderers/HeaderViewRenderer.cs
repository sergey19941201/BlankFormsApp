using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Util;
using Android.Widget;
using BlankFormsApp.Views;
using BlankFormsApp.Droid.Renderers;
 
[assembly: ExportRenderer(typeof(HeaderView), typeof(HeaderViewRenderer))]
namespace BlankFormsApp.Droid.Renderers
{
    public class HeaderViewRenderer : ViewRenderer<HeaderView, TextView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HeaderView> args)
        {
            base.OnElementChanged(args); 
            if (Control == null)
            {
                // создаем и настраиваем элемент
                TextView textView = new TextView(Context);
                textView.SetTextColor(Android.Graphics.Color.DarkGreen);
                textView.Text = "Android";
                textView.SetTextSize(ComplexUnitType.Dip, 28);
 
                // устанавливаем элемент для класса из Portable-проекта
                SetNativeControl(textView);
            }
        }
    }
}