using BlankFormsApp.Droid.Dependencies;
using BlankFormsApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace BlankFormsApp.Droid.Dependencies
{
    public class BaseUrl_Android: IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}