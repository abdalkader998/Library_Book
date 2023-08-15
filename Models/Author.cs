using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Author
    {
        [Key]
        [Required]
        public int AuthorID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Biography { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
