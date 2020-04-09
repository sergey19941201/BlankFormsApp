using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BlankFormsApp.MVVM.ViewModels
{
    public class ContextActionsPhonesListViewModel
    {
        public ObservableCollection<ContextActionsPhoneViewModel> Phones { get; set; }
        public ICommand MoveToTopCommand { protected set; get; }
        public ICommand MoveToBottomCommand { protected set; get; }
        public ICommand RemoveCommand { protected set; get; }
        public ContextActionsPhonesListViewModel()
        {
            Phones = new ObservableCollection<ContextActionsPhoneViewModel>
            {
                new ContextActionsPhoneViewModel { Title="HP Elite z3", Price=55000, Company="HP", ListViewModel=this},
                new ContextActionsPhoneViewModel {Title="Honor 8", Price= 28000, Company="Huawei", ListViewModel=this},
                new ContextActionsPhoneViewModel {Title="iPhone SE", Price=30000, Company="Apple", ListViewModel=this },
                new ContextActionsPhoneViewModel {Title="Galaxy Note 7", Price=60000, Company="Samsung", ListViewModel=this },
                new ContextActionsPhoneViewModel {Title="Lumia 950 XL", Price=36000, Company="Microsoft", ListViewModel=this }
            };
 
            MoveToTopCommand = new Command(MoveToTop);
            MoveToBottomCommand = new Command(MoveToBottom);
            RemoveCommand = new Command(Remove);
        }
 
        private void MoveToTop(object phoneObj)
        {
            ContextActionsPhoneViewModel phone = phoneObj as ContextActionsPhoneViewModel;
            if (phone == null) return;
            int oldIndex = Phones.IndexOf(phone);
            if (oldIndex > 0)
                Phones.Move(oldIndex, oldIndex - 1);
        }
        private void MoveToBottom(object phoneObj)
        {
            ContextActionsPhoneViewModel phone = phoneObj as ContextActionsPhoneViewModel;
            if (phone == null) return;
            int oldIndex = Phones.IndexOf(phone);
            if (oldIndex < Phones.Count-1)
                Phones.Move(oldIndex, oldIndex + 1);
        }
        private void Remove(object phoneObj)
        {
            ContextActionsPhoneViewModel phone = phoneObj as ContextActionsPhoneViewModel;
            if (phone == null) return;
 
            Phones.Remove(phone);
        }
    }
}