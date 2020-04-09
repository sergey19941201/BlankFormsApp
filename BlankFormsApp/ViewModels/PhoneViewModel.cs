using System.ComponentModel;
using BlankFormsApp.Entities;

namespace BlankFormsApp.ViewModels
{
    public class PhoneViewModel : BaseViewModel
    {
        private Phone phone;
 
        public PhoneViewModel()
        {
            phone = new Phone();
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
                }
            }
        }
    }
}