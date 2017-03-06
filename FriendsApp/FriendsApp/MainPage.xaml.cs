using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendsApp.Models;
using Xamarin.Forms;

namespace FriendsApp
{
    public partial class MainPage : ContentPage
    {
        private List<Friend> Friends;

        public MainPage()
        {
            InitializeComponent();
            InitDummyData();
            CreateFriendsList();
            FriendsCount.Text = Friends.Count.ToString();
        }

        private void InitDummyData()
        {
            Friends = new List<Friend>();

            Friends.Add(new Friend() { Name = "Bent H. Pedersen", Address = "Bentsvej 8", Email = "bhp@easv365.dk", PhoneNr = "69696969", ImageUrl = "bent.jpg" });
            Friends.Add(new Friend() { Name = "Kristian Iversen", Address = "Bugway 69", Email = "billethebug@easv365.dk", PhoneNr = "$3XY", ImageUrl = "bille.jpg" });
            Friends.Add(new Friend() { Name = "Morten Greis Hansen", Address = "Hillerupvej 99", Email = "mort5240@gmail.com", PhoneNr = "40294598", ImageUrl = "mort.jpg" });
            Friends.Add(new Friend() { Name = "Stefan Thomsen", Address = "Tarproad 22", Email = "st@networks.dk", PhoneNr = "B00BZ", ImageUrl = "stefan.jpg" });
            Friends.Add(new Friend() { Name = "Maja Liv Mejborn", Address = "Somewhereinføvling 22", Email = "majsen@nice.dk", PhoneNr = "$3XYT00!", ImageUrl = "tove.jpg" });
            Friends.Add(new Friend() { Name = "Nicolai Mensel Jørgensen", Address = "Fynsgade 23", Email = "menstuensel@gmail.com", PhoneNr = "H0TT13P13", ImageUrl = "mensel.jpg" });
        }

        //This method generates the XAML needed to fill the FriendList.
        private void CreateFriendsList()
        {
            FriendsList.ItemsSource = Friends;
        }

        private async void FriendsList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage(e.SelectedItem as Friend));
        }
    }
}
