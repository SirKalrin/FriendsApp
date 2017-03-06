using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FriendsApp.Models
{
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

        public Friend()
        {
            
        }
    }


}
