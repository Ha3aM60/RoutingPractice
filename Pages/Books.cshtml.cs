using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibraryApp.Models;
using LibraryApp.Data;

namespace RoutingPractice.Pages
{
    public class BooksModel : PageModel
    {
        public IEnumerable<Book> Books;
        private readonly IBookRepository _bookRepository;

        public BooksModel(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public void OnGet()
        {
            Books = _bookRepository.GetAllBooks();
        }
        public Book Book { get;private set; }
        public void OnGetDetails(int id)
        {
            Book = _bookRepository.GetBookById(id);
        }
    }
}
