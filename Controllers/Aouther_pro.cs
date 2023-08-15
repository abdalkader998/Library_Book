using Microsoft.AspNetCore.Mvc;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    public class Aouther_pro : Controller
    {
        private readonly LibraryService _libraryService;
        public Aouther_pro(LibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        public IActionResult Index()
        {
            var authorsWithBooks = _libraryService.GetAuthorsWithBooks();
            return View(authorsWithBooks);
        }
    }
}
