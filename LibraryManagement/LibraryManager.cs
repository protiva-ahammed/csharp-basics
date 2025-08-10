using System;
using System.Collections.Generic;
using System.Linq;

class LibraryManager
{

    private const int MaxBooks = 5;
    private const int MaxBorrowLimit = 3;

    private static List<string> books = new List<string>();
    private static Dictionary<string, List<string>> userBorrowedBooks = new Dictionary<string, List<string>>();

    public static void LibraryManage()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an action: add / remove / search / borrow / return / exit");
            string action = Console.ReadLine()?.Trim().ToLower();

            switch (action)
            {
                case "add":
                    AddBook();
                    break;

                case "remove":
                    RemoveBook();
                    break;

                case "search":
                    SearchBook();
                    break;

                case "borrow":
                    BorrowBook();
                    break;

                case "return":
                    ReturnBook();
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Invalid action. Try again.");
                    break;
            }

            DisplayBooks();
        }
    }

    private static void AddBook()
    {
        if (books.Count >= MaxBooks)
        {
            Console.WriteLine("Library is full.");
            return;
        }

        Console.WriteLine("Enter book title to add:");
        string title = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Invalid title.");
        }
        else if (books.Any(b => b.Equals(title, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Book already exists.");
        }
        else
        {
            books.Add(title);
            Console.WriteLine($"'{title}' added.");
        }
    }

    private static void RemoveBook()
    {
        Console.WriteLine("Enter book title to remove:");
        string title = Console.ReadLine()?.Trim();

        var book = books.FirstOrDefault(b => b.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine($"'{book}' removed.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    private static void SearchBook()
    {
        Console.WriteLine("Enter book title to search:");
        string title = Console.ReadLine()?.Trim();

        bool found = books.Any(b => b.Equals(title, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(found ? $"'{title}' is available." : "Book not found.");
    }

    private static void BorrowBook()
    {
        Console.WriteLine("Enter your name:");
        string user = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(user))
        {
            Console.WriteLine("Invalid user name.");
            return;
        }

        if (!userBorrowedBooks.ContainsKey(user))
        {
            userBorrowedBooks[user] = new List<string>();
        }

        if (userBorrowedBooks[user].Count >= MaxBorrowLimit)
        {
            Console.WriteLine("Borrow limit reached.");
            return;
        }

        Console.WriteLine("Enter book title to borrow:");
        string title = Console.ReadLine()?.Trim();

        var book = books.FirstOrDefault(b => b.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            books.Remove(book);
            userBorrowedBooks[user].Add(book);
            Console.WriteLine($"'{book}' borrowed by {user}.");
        }
        else
        {
            Console.WriteLine("Book not available.");
        }
    }

    private static void ReturnBook()
    {
        Console.WriteLine("Enter your name:");
        string user = Console.ReadLine()?.Trim();

        if (!userBorrowedBooks.ContainsKey(user) || userBorrowedBooks[user].Count == 0)
        {
            Console.WriteLine("No borrowed books found.");
            return;
        }

        Console.WriteLine("Enter book title to return:");
        string title = Console.ReadLine()?.Trim();

        var book = userBorrowedBooks[user].FirstOrDefault(b => b.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            userBorrowedBooks[user].Remove(book);
            books.Add(book);
            Console.WriteLine($"'{book}' returned by {user}.");
        }
        else
        {
            Console.WriteLine("You haven't borrowed this book.");
        }
    }

    private static void DisplayBooks()
    {
        Console.WriteLine("\n📚 Available Books:");
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine($"- {book}");
            }
        }
    
    }
}
