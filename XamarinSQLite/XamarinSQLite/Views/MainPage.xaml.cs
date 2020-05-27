using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSQLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            
            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.BtcFromSqlite, (NavigationPage)Detail);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            //Get All Persons
            var personList = await App.SQLiteDb.GetItemsAsync();
            if(personList!=null)
            {
                // lstPersons.ItemsSource = personList;
            }
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int) MenuItemType.BtcFromSqlite:
                        MenuPages.Add(id, new NavigationPage(new SQLitePage()));
                        break;
                    case (int) MenuItemType.BtcFromServer:
                        MenuPages.Add(id, new NavigationPage(new ServerPage()));
                        break;
                }
            }
            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}
