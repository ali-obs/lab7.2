class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    private int _pages;
    public int Pages
    {
        get => _pages;
        set
        {
            if (value > 0)
                _pages = value;
            else
                _pages = 1;
        }
    }
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }
    public string Info()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }
}
class Program
{
    static void Main()
    {
        Book[] books = new Book[]
        {
            new Book("Suç ve Ceza", "Dostoyevski", 687),
            new Book("1984", "George Orwell", 328),
            new Book("Simyacı", "Paulo Coelho", 184)
        };

        Console.WriteLine("--- All Books ---");
        foreach (Book b in books)
        {
            Console.WriteLine(b.Info());
        }
        Book maxBook = books[0];
        foreach (Book b in books)
        {
            if (b.Pages > maxBook.Pages)
            {
                maxBook = b;
            }
        }
        Console.WriteLine("\n--- Book with Most Pages ---");
        Console.WriteLine(maxBook.Info());
    }
}