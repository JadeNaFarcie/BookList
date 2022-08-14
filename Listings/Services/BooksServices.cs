using Listings.Models;

namespace Listings.Services;
public static class BooksServices
{
static List<Book> Books {get; }
static int nextId = 3;

static BooksServices()
{
    Books = new List<Book>
    {
        new Book{Id = 1, Title = "The last wish", Author = "Andrzej Sapkowski",Completed = true},
        new Book{Id = 2, Title = "The Lady of the Lake", Author = "Andrzej Sapkowski",Completed = false}
    };
}

public static List<Book> GetAll() => Books;

public static Book? Get(int id) => Books.FirstOrDefault(x => x.Id == id);

public static void Add(Book book){
    book.Id = nextId++;
    Books.Add(book);
}

public static void Update(Book book){
    var index = Books.FindIndex(x => x.Id == book.Id);
    if(index == -1)
        return;

    Books[index] = book;
}

public static void Delete(int id){
    var book = Get(id);
    if(book is null)
        return;
    Books.Remove(book);
}

}
