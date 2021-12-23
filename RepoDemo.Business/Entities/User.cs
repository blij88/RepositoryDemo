using System.ComponentModel.DataAnnotations;

namespace RepositoryDemo.business.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
