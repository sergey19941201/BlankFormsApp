using System;
using System.ComponentModel;
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
                Xamarin.Forms.Color color = Element.TextColor;
                var andrColor = Android.Graphics.Color.Argb(
                    (byte) (color.A * 255),
                    (byte) (color.R * 255),
                    (byte) (color.G * 255),
                    (byte) (color.B * 255));
                textView.SetTextColor(andrColor);
                textView.Text = Element.Text;
                textView.SetTextSize(ComplexUnitType.Dip, 28);
                textView.SetPadding(30, 30, 30, 30);

                textView.Click -= TextView_Click;
                textView.Click += TextView_Click;

                // устанавливаем элемент для класса из Portable-проекта
                SetNativeControl(textView);
            }

            // установка свойств
            if (args.NewElement != null)
            {
                SetText();
                SetTextColor();
            }
        }

        private void TextView_Click(object sender, EventArgs e)
        {
            if (Element != null)
                Element.FireClick(System.EventArgs.Empty);
        }

        // изменения свойства
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == HeaderView.TextColorProperty.PropertyName)
            {
                SetTextColor();
            }
            else if (e.PropertyName == HeaderView.TextProperty.PropertyName)
            {
                SetText();
            }
        }

        private void SetText()
        {
            Control.Text = $"{Element.Text} {Control.Text} из рендерера";
        }

        private void SetTextColor()
        {
            Android.Graphics.Color andrColor = Android.Graphics.Color.Gray;

            if (Element.TextColor != Xamarin.Forms.Color.Default)
            {
                Xamarin.Forms.Color color = Element.TextColor;
                andrColor = Android.Graphics.Color.Argb(
                    (byte) (color.A * 255),
                    (byte) (color.R * 255),
                    (byte) (color.G * 255),
                    (byte) (color.B * 255));
            }

            Control.SetTextColor(andrColor);
        }
    }
}