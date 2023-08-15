using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]  
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }
    }
}
