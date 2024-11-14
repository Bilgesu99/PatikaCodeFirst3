using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirst3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        // Navigation property
        public ICollection<Post> Posts { get; set; } // Bir kullanıcının birden fazla gönderisi olabilir
    }
}
