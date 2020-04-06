using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankFormsApp.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceInfoPage : ContentPage
    {
        public DeviceInfoPage()
        {
            InitializeComponent();
            
            var deviceInfo = DependencyService.Get<IDeviceInfo>();
            
            infoLabel.Text = deviceInfo.GetInfo();
            infoLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
        }
    }
}