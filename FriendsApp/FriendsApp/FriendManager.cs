using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FriendsApp.Models;

namespace FriendsApp
{
    public class FriendManager
    {
        private static FriendManager _instance;
        private List<Friend> _friends;

        private FriendManager()
        {
            InitDummyData();
        }

        public List<Friend> GetFriendsLst()
        {
            return _friends;
        }

        public void DeleteFriend(Friend friend)
        {
            _friends.Remove(friend);
        }

        public static FriendManager GetInstance()
        {
            return _instance ?? (_instance = new FriendManager());
        }

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


    }
}