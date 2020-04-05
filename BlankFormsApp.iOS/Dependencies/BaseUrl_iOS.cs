using System.Runtime.CompilerServices;
using BlankFormsApp.Interfaces;
using BlankFormsApp.iOS.Dependencies;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl_iOS))]

namespace BlankFormsApp.iOS.Dependencies
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}