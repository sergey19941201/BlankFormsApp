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
    public partial class ReusableViewPage : ContentPage
    {
        List<string> users;

        public ReusableViewPage()
        {
            InitializeComponent();

            users = new List<string>()
            {
                "Иван Иванов",
                "Олег Кузнецов",
                "Денис Петров",
                "Иван Сидоров",
                "Петр Денисов"
            };
            usersList.ItemsSource = users;
        }

        private void SearchUsers(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                usersList.ItemsSource = users.Where(u => u.ToLower().Contains(text.ToLower()));
            }
            else
            {
                usersList.ItemsSource = users;
            }
        }
    }
}