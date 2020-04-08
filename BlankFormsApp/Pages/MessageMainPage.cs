using System;
using BlankFormsApp.Entities;
using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class MessageMainPage : ContentPage
    {
        Label stackLabel;

        public MessageMainPage()
        {
            Title = "Main Page";
            Button forwardButton = new Button
            {
                Text = "Вперед"
            };
            forwardButton.Clicked += GoToForward;

            stackLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            Content = new StackLayout {Children = {forwardButton, stackLabel}};
            // устанавливаем подписку на сообщения
            Subscribe();
        }

        // установка подписки на сообщения
        private void Subscribe()
        {
            MessagingCenter.Subscribe<Page, Phone>(
                this, // кто подписывается на сообщения
                "LabelChange", // название сообщения
                (sender, args) =>
                {
                    var phone = args as Phone;
                    if (phone == null)
                    {
                        return;;
                    }

                    stackLabel.Text = $"Title: {phone.Title}\nCompany: {phone.Company}\nPrice: {phone.Price}";
                }); // вызываемое действие
        }

        // Переход вперед на MessagePage
        private async void GoToForward(object sender, EventArgs e)
        {
            MessagePage page = new MessagePage();
            await Navigation.PushAsync(page);
        }
    }
}