using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Listings.Models;
using Listings.Services;

namespace Listings.Pages
{
    public class BookUpdateModel : PageModel
    {

        [BindProperty]
        public Book? EditBook {get;set;}
        
        public void OnGet(int id)
        {
            
           EditBook =  BooksServices.Get(id);
        }

        public IActionResult OnPost()
        {
        BooksServices.Update(EditBook);
        return RedirectToPage("Book");;
        }
    }
}
