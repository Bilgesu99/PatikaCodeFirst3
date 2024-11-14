using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaCodeFirst3.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // Foreign key
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } // Her gönderi bir kullanıcıya ait
    }
}
