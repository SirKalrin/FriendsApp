using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendsApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Friend selectedFriend)
        {
            InitializeComponent();

        }
    }
}
