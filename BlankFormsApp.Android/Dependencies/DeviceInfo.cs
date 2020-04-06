using Android.OS;
using BlankFormsApp.Droid.Dependencies;
using BlankFormsApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceInfo))]

namespace BlankFormsApp.Droid.Dependencies
{
    public class DeviceInfo : IDeviceInfo
    {
        public string GetInfo()
        {
            return $"Android {Build.VERSION.Release}";
        }
    }
}