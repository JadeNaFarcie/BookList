using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Listings.Models;
using Listings.Services;

namespace Listings.Pages
{
    public class BookModel : PageModel
    {
        public List<Book> books = new();
        
        [BindProperty]
        public Book NewBook {get;set;} = new();

        public void OnGet()
        {
        books = BooksServices.GetAll();
        }

        public string Completed(Book book)
        {
            if(book.Completed)
            return "Completed";
        return "Not Completed";
        }
        public IActionResult OnPost()
        {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        BooksServices.Add(NewBook);
        return RedirectToAction("Get");
        }
        public IActionResult OnPostEdit(int id){
            return RedirectToPage("BookUpdate", new { id = id });
        }
        public IActionResult OnPostDelete(int id)
        {
            BooksServices.Delete(id);
            return RedirectToAction("Get");
        }
    
    }
}
