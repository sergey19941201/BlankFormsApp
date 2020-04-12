using System;
using System.IO;
using BlankFormsApp.Interfaces;
using BlankFormsApp.Localization;
using BlankFormsApp.Pages;
using BlankFormsApp.SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";

        // Synchronous Repo
        //public static FriendRepository database;
        public static FriendAsyncRepository database;

        public static FriendAsyncRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FriendAsyncRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }

                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            // Uncomment if English by default is needed 
            //SetEnglishCultureAsDefault();

            // MainPage = new MainPage();
            //MainPage = new StartPage();
            //MainPage = new MyPage();
            //MainPage = new StackLayoutPage();
            //MainPage = new ScrollViewPage();
            //MainPage = new AbsoluteLayoutPage();
            // MainPage = new AbsoluteLayoutXamlPage();
            // MainPage = new RelativeLayoutPage();
            //MainPage = new GridPage();
            //MainPage = new TableViewPage();
            //MainPage = new WebViewPage();
            // MainPage = new AlertsPage();
            //MainPage = new OnPlatformInXamlPage();
            // MainPage = new DeviceInfoPage();
            //MainPage = new ResourcesPage();
            // MainPage = new StylesPage();
            // MainPage = new TriggerPage();
            // MainPage = new VisualStateManagerPage();
            //MainPage = new BindingPage(); 
            // MainPage = new ConverterPage();
            //MainPage = new BindingToCustomEntityWithINotifyPropertyChangedPage();
            //MainPage = new ListViewStaticInXamlPage();
            // MainPage = new ListViewC_BindingPage();
            // MainPage = new ListViewCustomViewCellPage();
            //MainPage = new ListViewImageCellPage();
            // MainPage = new ListViewCustomReusableViewCellPage();
            // MainPage = new ListViewObservableCollectionPage();
            // MainPage = new ListViewGroupingPage();
            // MainPage = new DataTriggersPage(); 
            // MainPage = new NavigationPage(new NavigationMainPage());
            //MainPage = new NavigationPage(new MessageMainPage());
            //MainPage = new TabbedMainPage();
            // MainPage = new PropertiesPage();
            // MainPage = new FilesPage();
            // MainPage = new MVVMPage();
            //MainPage = new NavigationPage(new MVVMFriendsListPage());
            //MainPage = new MVVMContextActionsPhonesListPage();
            // MainPage = new NavigationPage(new SQLitePage());
            //MainPage = new LocalizationPage();
            // MainPage = new InternetConnectivity();
            // MainPage = new InternetGetDataFromServer();
            //MainPage = new ReusableViewPage();
            //MainPage = new CustomRendererPage();
            MainPage = new CameraPage();
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
            //MainPage = new 
        }

        private void SetEnglishCultureAsDefault()
        {
            AppResources.Culture = DependencyService.Get<ILocalize>()
                .GetCurrentCultureInfo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}