using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResourcesPage : ContentPage
    {
        public ResourcesPage()
        {
            InitializeComponent();
        }
        
        private void ColorChange(object sender, EventArgs e)
        {
            Color textColor = (Color)Application.Current.Resources["appButtonTextColor"];
            // Change resource value
            Resources["appButtonTextColor"] = textColor == Color.Red ? Color.Green : Color.Red;
        }
    }
}