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
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            SetupWebView();
        }

        private void SetupWebView()
        {
            UrlWebViewSource urlSource = new UrlWebViewSource();
            urlSource.Url = System.IO.Path.Combine(DependencyService.Get<IBaseUrl>().Get(), "index.html");
            webView.Source = urlSource;
        }
    }
}