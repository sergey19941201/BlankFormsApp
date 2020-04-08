using System;
using BlankFormsApp.Entities;
using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class MessagePage : ContentPage
    {
        public MessagePage()
        {
            Title = "MessagePage";
            Button backBtn = new Button
            {
                Text = "Назад"
            };
            backBtn.Clicked += GoToBack;
 
            Content = new StackLayout { Children = { backBtn} };
        }
        // Переход обратно на MainPage
        private async void GoToBack(object sender, EventArgs e)
        {
            var phone = new Phone
            {
                Title = "my title",
                Company = "my company",
                Price = 232
            };
            // отправляем сообщение
            MessagingCenter.Send<Page, Phone>(this, "LabelChange", phone);
            await Navigation.PopAsync();
        }
    }
}