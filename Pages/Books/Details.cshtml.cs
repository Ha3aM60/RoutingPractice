using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoutingPractice.Pages.Books
{
    public class DetailsModel : PageModel
    {
        int ID;
        public Book book;
        private readonly IBookRepository _bookRepository;
        public DetailsModel(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void OnGet(int id)
        {
            ID = id;
            book = _bookRepository.GetBookById(id);
        }
    }
}
