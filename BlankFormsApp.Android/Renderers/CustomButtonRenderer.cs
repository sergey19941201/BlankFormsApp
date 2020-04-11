using System;
using System.ComponentModel;
using Android.Support.V4.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Util;
using Android.Widget;
using BlankFormsApp.Views;
using BlankFormsApp.Droid.Renderers;
using Xamarin.Forms.PlatformConfiguration;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace BlankFormsApp.Droid.Renderers
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.ParseColor("#80000000")); 
            }
        }
    }
}