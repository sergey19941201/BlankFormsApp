using BlankFormsApp.Interfaces;
using BlankFormsApp.iOS.Dependencies;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfo))]
namespace BlankFormsApp.iOS.Dependencies
{
    public class DeviceInfo: IDeviceInfo
    {
        public string GetInfo()
        {
            UIDevice device = new UIDevice();
            return $"{device.SystemName} {device.SystemVersion}";
        }
    }
}