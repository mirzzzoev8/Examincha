using Task6;

System.Console.WriteLine("Enter your book :");
var book1 = new Book();
book1.Id = 1;
book1.Title = "Yusufjon";
book1.Author = "Abbos";
var lib = new Library();
lib.AddBook(book1);
lib.DisplayBooks();
lib.UpdateBook(book1);



var book2 = new Book();
book2.Id = 2;
book2.Title = "Yusuf";
book2.Author = "Rahim";
var lib1 = new Library();
lib1.AddBook(book2);
lib1.DisplayBooks();
lib1.UpdateBook(book2);




