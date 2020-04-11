using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using BlankFormsApp.Views;
using BlankFormsApp.iOS.Renderers;

[assembly: ExportRenderer(typeof(TextSizedLabel), typeof(TextSizedLabelRenderer))]
namespace BlankFormsApp.iOS.Renderers
{
    public class TextSizedLabelRenderer : ViewRenderer<TextSizedLabel, UILabel>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TextSizedLabel> args)
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
                    Font = UIFont.SystemFontOfSize(Element.MyTextSize)
                };
                SetNativeControl(uilabel);
            }
            
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
            Control.Font = UIFont.SystemFontOfSize(Element.MyTextSize);
        }
    }
}