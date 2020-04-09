using System.Collections.ObjectModel;
using System.Windows.Input;
using BlankFormsApp.Pages;
using Xamarin.Forms;

namespace BlankFormsApp.MVVM.ViewModels
{
    public class FriendsListViewModel : BaseViewModel
    {
        public ObservableCollection<FriendViewModel> Friends { get; set; }
        
        public ICommand CreateFriendCommand { protected set; get; }
        public ICommand DeleteFriendCommand { protected set; get; }
        public ICommand SaveFriendCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        FriendViewModel selectedFriend;
 
        public INavigation Navigation { get; set;}
 
        public FriendsListViewModel()
        {
            Friends = new ObservableCollection<FriendViewModel>();
            CreateFriendCommand = new Command(CreateFriend);
            DeleteFriendCommand = new Command(DeleteFriend);
            SaveFriendCommand = new Command(SaveFriend);
            BackCommand = new Command(Back);
        }
 
        public FriendViewModel SelectedFriend
        {
            get { return selectedFriend; }
            set
            {
                if (selectedFriend != value)
                {
                    FriendViewModel tempFriend = value;
                    selectedFriend = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new MVVMFriendPage(tempFriend));
                }
            }
        }
        
        private void CreateFriend()
        {
            Navigation.PushAsync(new MVVMFriendPage(new FriendViewModel() { ListViewModel = this }));
        }
        
        private void Back()
        {
            Navigation.PopAsync();
        }
        
        private void SaveFriend(object friendObject)
        {
            FriendViewModel friend = friendObject as FriendViewModel;
            if (friend != null && friend.IsValid)
            {
                Friends.Add(friend);
            }
            Back();
        }
        
        private void DeleteFriend(object friendObject)
        {
            FriendViewModel friend = friendObject as FriendViewModel;
            if (friend != null)
            {
                Friends.Remove(friend);
            }
            Back();
        }
    }
}