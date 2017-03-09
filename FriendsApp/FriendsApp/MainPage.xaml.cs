using System.Collections.Generic;
using FriendsApp.Models;
using Xamarin.Forms;

namespace FriendsApp
{
    /*
     * This is the c# for the first xaml Page shown to the User
     */
    public partial class MainPage : ContentPage
    {
        public int NumberOfFriends { get; set; } // We use this to bind to the xaml view
        private FriendManager _friendMgr;

        public MainPage()
        {
            InitializeComponent();
            _friendMgr = FriendManager.GetInstance();
            FriendsList.ItemsSource = _friendMgr.GetFriendsLst();
            NumberOfFriends = _friendMgr.GetFriendsLst().Count;
            BindingContext = this; // This ensures that NumberOfFriends is recognized in the xaml view and can be used for binding.
        }

        /*
         * Dummy data for initializing the list of friends.
         */

        /*
         * ItemSelectedEvent from ListView FriendsList. This adds a new Page to the stack using the Navigation tools.
         */
        //private async void FriendsList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    await Navigation.PushAsync(new DetailsPage(e.SelectedItem as Friend));
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FriendsList.ItemsSource = null;
            FriendsList.ItemsSource = _friendMgr.GetFriendsLst();
        }

        private async void FriendsList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage(e.Item as Friend));
        }
    }
}
