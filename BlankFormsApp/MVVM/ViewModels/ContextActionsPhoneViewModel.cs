using BlankFormsApp.Entities;

namespace BlankFormsApp.MVVM.ViewModels
{
    public class ContextActionsPhoneViewModel : BaseViewModel
    {
        public Phone Phone { get; set; }
        public ContextActionsPhonesListViewModel ListViewModel { get; set; }
        
        public ContextActionsPhoneViewModel()
        {
            Phone = new Phone();
        }
        public string Title
        {
            get { return Phone.Title; }
            set
            {
                if (Phone.Title != value)
                {
                    Phone.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        public string Company
        {
            get { return Phone.Company; }
            set
            {
                if (Phone.Company != value)
                {
                    Phone.Company = value;
                    OnPropertyChanged("Company");
                }
            }
        }
        public int Price
        {
            get { return Phone.Price; }
            set
            {
                if (Phone.Price != value)
                {
                    Phone.Price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
    }
}