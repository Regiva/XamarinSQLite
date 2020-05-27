using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSQLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServerPage : ContentPage
    {
        // DecksViewModel viewModel;

        public ServerPage()
        {
            // BindingContext = viewModel = new DecksViewModel();
            
            InitializeComponent();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushModalAsync(new NavigationPage(new NewDeckPage()));
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // var item = args.SelectedItem as Deck;
            // if (item == null)
                return;

            // await Navigation.PushAsync(new DeckDetailPage(new DeckDetailViewModel(item)));

            // Manually deselect item.
            // DecksListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // if (viewModel.Decks.Count == 0)
                // viewModel.LoadDecksCommand.Execute(null);
        }
    }
}