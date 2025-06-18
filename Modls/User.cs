using System.ComponentModel.DataAnnotations;

namespace UserProfileSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Навигационное свойство
        public UserProfile Profile { get; set; }
    }
}