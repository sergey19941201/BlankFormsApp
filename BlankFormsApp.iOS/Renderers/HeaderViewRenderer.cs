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
                UILabel uilabel = new UILabel
                {
                    Text = "iOS",
                    TextColor = UIColor.Red,
                    Font = UIFont.SystemFontOfSize(25)
                };
                SetNativeControl(uilabel);
            }
        }
    }
}