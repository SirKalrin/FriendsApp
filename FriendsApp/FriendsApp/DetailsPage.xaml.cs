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
        private FriendManager _friendMgr;
        private Friend _selectedFriend;
        public DetailsPage(Friend selectedFriend)
        {
            InitializeComponent();
            _selectedFriend = selectedFriend;
            InfoContainer.BindingContext = selectedFriend;
            _friendMgr = FriendManager.GetInstance();
        }

        private async void EditBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditPage(_selectedFriend));
        }

        private async void DeleteBtn_OnClicked(object sender, EventArgs e)
        {
            
            if (await DisplayAlert("ALERT", $"Are you sure you want to delete{_selectedFriend.Name}", "Yes", "No"))
            {
                _friendMgr.DeleteFriend(_selectedFriend);
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                await Navigation.PopAsync();
            }
        }
    }
}
