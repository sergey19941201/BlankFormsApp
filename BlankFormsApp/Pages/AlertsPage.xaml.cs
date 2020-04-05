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
    public partial class AlertsPage : ContentPage
    {
        public AlertsPage()
        {
            InitializeComponent();
        }
        
        private void OnAlertClicked(object sender, EventArgs e)
        {
            DisplayAlert("Уведомление", "Пришло новое сообщение", "ОK");
        }
        
        private async void OnAlertWithChoiceClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы хотите удалить элемент?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: "+ (result ? "Удалить" : "Отменить"), "OK");
        }
        
        private async void OnAlertWithMultipleButtonsClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Поделиться", "Отмена", "Удалить", "Вконтакте", "Твиттер", "Фейсбук");
            actionLabel.Text = action;
        }
    }
}