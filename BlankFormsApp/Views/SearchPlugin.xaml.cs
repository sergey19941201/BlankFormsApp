using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Views
{
    public delegate void SearchPluginEventHandler(string text);
    public partial class SearchPlugin : ContentView
    {
        public event SearchPluginEventHandler Search;
        
        public SearchPlugin()
        {
            InitializeComponent();
        }
        
        private void OnClicked(object sender, EventArgs e)
        {
            Search?.Invoke(searchEntry.Text);
        }
    }
}