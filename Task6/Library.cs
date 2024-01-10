namespace Task6;

public class Library : ILibrary
{
    public List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
      books.Add(book);
      
    }
    public Book DisplayBooks()
    {
       return books ;
    }
    public void UpdateBook(Book book)
    {
        var bk = books.FirstOrDefault(e => e.Id == book.Id);
        bk.Title = book.Title;
        bk.Author = bk.Author;
    }

    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(e => e.Id == id);
        books.Remove(book);
    }
    public Book SearchByTitle(string title)
    {
        var tit = books.FirstOrDefault(e => e.Title == title);
        return tit;
    }

    

    public Book SearchByAuthor(string author)
    {
        var tit1 = books.FirstOrDefault(e => e.Author == author);
        return tit1;

        
    }

    

}
