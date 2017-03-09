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
    public partial class EditPage : ContentPage
    {
        private bool _edited;
        private Friend _selectedFriend;
        public EditPage(Friend selectedFriend)
        {
            _edited = false;
            _selectedFriend = selectedFriend;
            InitializeComponent();
            InfoContainer.BindingContext = selectedFriend;
        }
        /*
         * If any of the fields has been edited, the changes in the selected friend is saved, a succes aleart is displayed, and the user is redirected to the selected friends details view.
         * 
         * If nothing has been edited, an alert with that info is displayed, and the user is redirected to the previous page.
        */
        private async void SaveBtn_OnClicked(object sender, EventArgs e)
        {
            if (_edited)
            {
                if (Name.Text != null)
                    _selectedFriend.Name = Name.Text;
                if (Address.Text != null)
                    _selectedFriend.Address = Address.Text;
                if (Email.Text != null)
                    _selectedFriend.Email = Email.Text;
                if (GpsLocation.Text != null)
                    _selectedFriend.GpsLocation = GpsLocation.Text;
                if (Homepage.Text != null)
                    _selectedFriend.HomepageUrl = Homepage.Text;
                if (PhoneNr.Text != null)
                    _selectedFriend.PhoneNr = PhoneNr.Text;
                if (Image.Text != null)
                    _selectedFriend.ImageUrl = Image.Text;
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]); 
                //Removes the page that directed the user to this page from the navigation stack. 
                //Reason: incorrect data in previous page if friend is edited.

                await DisplayAlert("SUCCES", "Your changes has beed saved", "OK");
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                await Navigation.PushAsync(new DetailsPage(_selectedFriend));
            }
            else
            {
                await DisplayAlert("ALERT", "Nothing has been edited!", "OK");
                Navigation.PopAsync();
            }
        }

        private async void CancelBtn_OnClicked(object sender, EventArgs e)
        {
            if (_edited)
            {
                if (await DisplayAlert("ALERT", "Are you sure you want to discard your changes?", "Yes", "No"))
                {
                    Navigation.PopAsync();
                }
            }
            else
            {
                Navigation.PopAsync();
            }
        }

        private void Edited(object sender, TextChangedEventArgs e)
        {
            _edited = true;
        }
    }
}
