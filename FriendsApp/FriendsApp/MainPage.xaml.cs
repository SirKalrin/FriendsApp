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
        private List<Friend> _friends;
        public int NumberOfFriends { get; set; } // We use this to bind to the xaml view

        public MainPage()
        {
            InitializeComponent();
            InitDummyData();
            FriendsList.ItemsSource = _friends;
            NumberOfFriends = _friends.Count;
            BindingContext = this; // This ensures that NumberOfFriends is recognized in the xaml view and can be used for binding.
        }

        /*
         * Dummy data for initializing the list of friends.
         */
        private void InitDummyData()
        {
            _friends = new List<Friend>();
            _friends.Add(new Friend()
            {
                Name = "Bent H. Pedersen",
                Address = "Bentsvej 8",
                Email = "bhp@easv365.dk",
                PhoneNr = "69696969",
                ImageUrl = "bent.jpg",
                GpsLocation = "Sverige",
                HomepageUrl = "http://www.gørdetbent.dk"
            });
            _friends.Add(new Friend()
            {
                Name = "Kristian Iversen",
                Address = "Bugway 69",
                Email = "billethebug@easv365.dk",
                PhoneNr = "$3XY",
                ImageUrl = "bille.jpg",
                GpsLocation = "Norge",
                HomepageUrl = "http://www.billboy.dk"
            });
            _friends.Add(new Friend()
            {
                Name = "Morten Greis Hansen",
                Address = "Hillerupvej 99",
                Email = "mort5240@gmail.com",
                PhoneNr = "40294598",
                ImageUrl = "mort.jpg",
                GpsLocation = "Denmark",
                HomepageUrl = "http://www.greis.ownage"
            });
            _friends.Add(new Friend()
            {
                Name = "Stefan Thomsen",
                Address = "Tarproad 22",
                Email = "st@networks.dk",
                PhoneNr = "B00BZ",
                ImageUrl = "stefan.jpg",
                GpsLocation = "Nederlands",
                HomepageUrl = "http://www.stmaster.dk"
            });
            _friends.Add(new Friend()
            {
                Name = "Maja Liv Mejborn",
                Address = "Somewhereinføvling 22",
                Email = "majsen@nice.dk",
                PhoneNr = "$3XYT00!",
                ImageUrl = "tove.jpg",
                GpsLocation = "Denmark",
                HomepageUrl = "http://www.awesomemajsen.dk"
            });
            _friends.Add(new Friend()
            {
                Name = "Nicolai Mensel Jørgensen",
                Address = "Fynsgade 23",
                Email = "menstuensel@gmail.com",
                PhoneNr = "H0TT13P13",
                ImageUrl = "mensel.jpg",
                GpsLocation = "Canada",
                HomepageUrl = "http://www.menstruensel.dk"
            });
        }

        /*
         * ItemSelectedEvent from ListView FriendsList. This adds a new Page to the stack using the Navigation tools.
         */
        private async void FriendsList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage(e.SelectedItem as Friend));
        }
    }
}
