using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Util;
using Android.Widget;
using BlankFormsApp.Views;
using BlankFormsApp.Droid.Renderers;

[assembly: ExportRenderer(typeof(TextSizedLabel), typeof(TextSizedLabelRenderer))]

namespace BlankFormsApp.Droid.Renderers
{
    public class TextSizedLabelRenderer : ViewRenderer<TextSizedLabel, TextView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TextSizedLabel> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
            {
                // создаем и настраиваем элемент
                TextView textView = new TextView(Context);
                Xamarin.Forms.Color color = Element.TextColor;
                var andrColor = Android.Graphics.Color.Argb(
                    (byte) (color.A * 255),
                    (byte) (color.R * 255),
                    (byte) (color.G * 255),
                    (byte) (color.B * 255));
                textView.SetTextColor(andrColor);
                textView.Text = Element.Text;
                // устанавливаем элемент для класса из Portable-проекта
                SetNativeControl(textView);
            }

            // установка свойств
            if (args.NewElement != null)
            {
                SetTextSize();
            }
        }

        // изменения свойства
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == TextSizedLabel.MyTextSizeProperty.PropertyName)
            {
                SetTextSize();
            }
        }

        private void SetTextSize()
        {
            Control.SetTextSize(ComplexUnitType.Dip, Element.MyTextSize);
        }
    }
}