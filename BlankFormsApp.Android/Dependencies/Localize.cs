using BlankFormsApp.Droid.Dependencies;
using BlankFormsApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Localize))]
namespace BlankFormsApp.Droid.Dependencies
{
    public class Localize : ILocalize
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.English;
            var netLanguage = androidLocale.ToString().Replace("_", "-");
            return new System.Globalization.CultureInfo(netLanguage);
        }
    }
}