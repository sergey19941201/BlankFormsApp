using BlankFormsApp.Interfaces;
using Plugin.Messaging;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class PhoneCallPage : ContentPage
    {
        Entry phoneNumberEntry;
        Button callButton, messageButton, emailButton;

        public PhoneCallPage()
        {
            this.Padding = new Thickness(10, 80, 10, 10);

            phoneNumberEntry = new Entry {Placeholder = "Введите номер"};
            callButton = new Button {Text = "Call"};
            callButton.Clicked += (o, e) =>
            {
                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                if (phoneDialer.CanMakePhoneCall)
                    phoneDialer.MakePhoneCall(phoneNumberEntry.Text);
            };

            messageButton = new Button {Text = "Message"};
            messageButton.Clicked += (o, e) =>
            {
                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms("+79876543210", "Hello World!");
            };

            emailButton = new Button {Text = "Email"};
            emailButton.Clicked += (o, e) =>
            {
                var emailMessenger = CrossMessaging.Current.EmailMessenger;
                if (emailMessenger.CanSendEmail)
                {
                    emailMessenger.SendEmail("адрес получателя", "тема письма", "текст письма");
                } 
            };

            Content = new StackLayout
            {
                Children = {phoneNumberEntry, callButton, messageButton, emailButton}
            };
        }
    }
}