namespace FriendsApp.Models
{
    /*
     * This class is our model for a friend in this application.
    */
    public class Friend
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string GpsLocation { get; set; }
        public string HomepageUrl { get; set; }
    }
}
