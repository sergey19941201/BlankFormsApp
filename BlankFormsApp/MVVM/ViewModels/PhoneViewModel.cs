using System.ComponentModel;
using System.Windows.Input;
using BlankFormsApp.Entities;
using BlankFormsApp.MVVM.Commands;
using Xamarin.Forms;

namespace BlankFormsApp.MVVM.ViewModels
{
    public class PhoneViewModel : BaseViewModel
    {
        private Phone phone;
        public ICommand Increase { get; }
        public ICommand Decrease { get; }

        public PhoneViewModel()
        {
            phone = new Phone();
            // Custom Command
            Increase = new IncreasePriceCommand(this);
            // Built-in Command
            Decrease = new Command(
                DecreasePrice,
                // Important! Predicate of Decrease Command will not work without ((Command)Decrease).ChangeCanExecute();
                () => { return Price > 0; });
        }

        public void IncreasePrice()
        {
            if (phone != null)
                Price += 10000;
        }

        public void DecreasePrice()
        {
            if (phone != null)
            {
                Price -= 10000;
            }
        }

        public string Title
        {
            get { return phone.Title; }
            set
            {
                if (phone.Title != value)
                {
                    phone.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Company
        {
            get { return phone.Company; }
            set
            {
                if (phone.Company != value)
                {
                    phone.Company = value;
                    OnPropertyChanged("Company");
                }
            }
        }

        public int Price
        {
            get { return phone.Price; }
            set
            {
                if (phone.Price != value)
                {
                    phone.Price = value;
                    OnPropertyChanged("Price");
                    // Important! Predicate of Decrease Command will not work without this
                    ((Command)Decrease).ChangeCanExecute();
                }
            }
        }
    }
}