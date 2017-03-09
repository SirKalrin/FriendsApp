using System;
using FriendsApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    /*
     * This is the c# for our custom xaml DetailsPage, displaying a Friend's information.
     */
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Friend selectedFriend)
        {
            InitializeComponent();
            InfoContainer.BindingContext = selectedFriend;
        }

        private void EditBtn_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
