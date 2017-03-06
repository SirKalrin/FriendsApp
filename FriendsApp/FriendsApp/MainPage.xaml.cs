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
        }

        //This method generates the XAML needed to fill the FriendList.
        private void CreateFriendsList()
        {
            FriendsList.ItemsSource = Friends;
        }
    }
}
