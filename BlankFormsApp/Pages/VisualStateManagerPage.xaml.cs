using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisualStateManagerPage : ContentPage
    {
        public VisualStateManagerPage()
        {
            InitializeComponent();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            entry.IsEnabled = !entry.IsEnabled;
        }
        
        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            // проверяем введенное значение на соответствие регулярному выражению
            bool isValid = Regex.IsMatch(e.NewTextValue, @"^\+[1-9]-\d{3}-\d{3}-\d{4}$");
            SetState(isValid);
        }
        // установка состояния Valid или Invalid
        void SetState(bool isValid)
        {
            string visualState = isValid ? "Valid" : "Invalid";
            // Correct number to test visual state +1-234-567-8901
            VisualStateManager.GoToState(customVisualState, visualState);
        }
    }
}