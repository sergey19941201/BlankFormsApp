using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static string HEADER = "Xamarin";

        public static double staticVar { get; set; } = 28;

        public  MainPage()
        {
            InitializeComponent();

            noob();
        }

        private async void noob()
        {
            await Task.Delay(1000);
            HEADER = "fkkfkkf";
        }
    }
}
