using BlankFormsApp.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class PhoneCallPage : ContentPage
    {
        Entry phoneNumberEntry;
        Button callButton;

        public PhoneCallPage()
        {
            this.Padding = new Thickness(10, 80, 10, 10);

            Title = "Телефон";
            phoneNumberEntry = new Entry {Placeholder = "Введите номер"};
            callButton = new Button {Text = "Call"};
            callButton.Clicked += async (o, e) => { PhoneDialer.Open(phoneNumberEntry.Text); };

            Content = new StackLayout
            {
                Children = {phoneNumberEntry, callButton}
            };
        }
    }
}