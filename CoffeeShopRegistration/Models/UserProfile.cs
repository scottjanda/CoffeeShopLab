using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistration.Models
{
    public class UserProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        [RegularExpression("[a-zA-Z0-9]+", ErrorMessage = "Only alpha-numeric characters allowed!")]
        public string Password { get; set; }
    }
}
