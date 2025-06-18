using System.ComponentModel.DataAnnotations;

namespace UserProfileSystem.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int UserId { get; set; }

        // Сделайте это nullable:
        public User? User { get; set; }
    }
}