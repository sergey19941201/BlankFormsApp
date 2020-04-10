using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Resources;
using System.Globalization;
using System.Reflection;
using BlankFormsApp.Localization;

namespace BlankFormsApp.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        readonly CultureInfo ci;
        const string ResourceId = "BlankFormsApp.Localization.AppResources";
 
        public TranslateExtension()
        {
            ci = AppResources.Culture;
        }
 
        public string Text { get; set; }
 
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return "";
 
            ResourceManager resmgr = new ResourceManager(ResourceId, 
                typeof(TranslateExtension).GetTypeInfo().Assembly);

            var translation = resmgr.GetString(Text, ci);
 
            if (translation == null)
            {
                translation = Text; 
            }
            return translation;
        }
    }
}