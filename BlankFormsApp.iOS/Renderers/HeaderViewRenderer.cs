using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using BlankFormsApp.Views;
using BlankFormsApp.iOS.Renderers;

[assembly: ExportRenderer(typeof(HeaderView), typeof(HeaderViewRenderer))]
namespace BlankFormsApp.iOS.Renderers
{
    public class HeaderViewRenderer : ViewRenderer<HeaderView, UILabel>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HeaderView> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
            {
                Xamarin.Forms.Color color = Element.TextColor;
                var iosColor = UIColor.FromRGBA(
                    (byte)(color.R * 255),
                    (byte)(color.G * 255),
                    (byte)(color.B * 255),
                    (byte)(color.A * 255));
                
                UILabel uilabel = new UILabel
                {
                    Lines = 0,
                    Text = Element.Text,
                    TextColor = iosColor,
                    Font = UIFont.SystemFontOfSize(25)
                };
                SetNativeControl(uilabel);
            }
            
            if (args.NewElement != null)
            {
                SetText();
                SetTextColor();
            }
        }
        
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
            UIColor iosColor = UIColor.Gray;
 
            if (Element.TextColor != Xamarin.Forms.Color.Default)
            {
                Xamarin.Forms.Color color = Element.TextColor;
                iosColor = UIColor.FromRGBA(
                    (byte)(color.R * 255),
                    (byte)(color.G * 255),
                    (byte)(color.B * 255),
                    (byte)(color.A * 255));
            }
            Control.TextColor = iosColor;
        }
    }
}