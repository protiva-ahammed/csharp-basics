using System;
using System.Collections.Generic;
using System.Linq;

class LibraryManager
{
    public static void LibraryManage()
    {
        const int MaxBooks = 5;
        List<string> books = new List<string>();

        while (true)
        {
            Console.WriteLine("\nWould you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine()?.Trim().ToLower();

            switch (action)
            {
                case "add":
                    if (books.Count >= MaxBooks)
                    {
                        Console.WriteLine("The library is full. No more books can be added.");
                    }
                    else
                    {
                        Console.WriteLine("Enter the title of the book to add:");
                        string newBook = Console.ReadLine()?.Trim();

                        if (string.IsNullOrWhiteSpace(newBook))
                        {
                            Console.WriteLine("Invalid book title.");
                        }
                        else if (books.Any(b => b.Equals(newBook, StringComparison.OrdinalIgnoreCase)))
                        {
                            Console.WriteLine("This book is already in the library.");
                        }
                        else
                        {
                            books.Add(newBook);
                            Console.WriteLine($"'{newBook}' added to the library.");
                        }
                    }
                    break;

                case "remove":
                    if (books.Count == 0)
                    {
                        Console.WriteLine("The library is empty. No books to remove.");
                    }
                    else
                    {
                        Console.WriteLine("Enter the title of the book to remove:");
                        string removeBook = Console.ReadLine()?.Trim();

                        var bookToRemove = books.FirstOrDefault(b => b.Equals(removeBook, StringComparison.OrdinalIgnoreCase));
                        if (bookToRemove != null)
                        {
                            books.Remove(bookToRemove);
                            Console.WriteLine($"'{bookToRemove}' removed from the library.");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                    }
                    break;

                case "exit":
                    return;

                default:
                    Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
                    break;
            }

            // Display the list of books
            Console.WriteLine("\nAvailable books:");
            if (books.Count == 0)
            {
                Console.WriteLine("No books currently in the library.");
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
}
