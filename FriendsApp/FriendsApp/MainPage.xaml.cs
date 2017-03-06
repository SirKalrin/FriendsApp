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

            Friends.Add(new Friend() { Name = "Kaj", Address = "Kajsvej 8", Email = "kaj@kaj.dk", PhoneNr = "69696969", ImageUrl = "power.png" });
            Friends.Add(new Friend() { Name = "Kaj", Address = "Kajsvej 8", Email = "kaj@kaj.dk", PhoneNr = "69696969", ImageUrl = "power.png" });
        }

        //This method generates the XAML needed to fill the FriendList.
        private void CreateFriendsList()
        {
            FriendsList.ItemsSource = Friends;
        }
    }
}
