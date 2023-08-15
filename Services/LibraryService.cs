using WebApplication6.Data;
using WebApplication6.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace WebApplication6.Services
{
    public class LibraryService
    {
        private readonly WebApplication6Context _context;

        public LibraryService(WebApplication6Context context)
        {
            _context = context;
        }

        public List<Author> GetAuthorsWithBooks()
        {
            var authorsWithBooks = _context.Author.Include(a => a.Books).ToList();
            return authorsWithBooks;
        }
    }
}
