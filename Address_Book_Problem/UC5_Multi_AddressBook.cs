using System;
using System.Collections.Generic;

namespace Address_Book_Problem
{
    public class MultipleAddressBooks
    {
        private readonly Dictionary<string, List<Dictionary<string, string>>> books 
            = new Dictionary<string, List<Dictionary<string, string>>>();

        public void Execute()
        {
            while (true)
            {
                Console.Write("Name your address book: ");
                string currentBook = Console.ReadLine();

                var creator = new AddMultipleContacts();
                var contacts = creator.Execute();
                books[currentBook] = contacts;

                Console.Write("Create another book? (y/n): ");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice != "y") break;
            }

            Console.WriteLine("\n--- All Address Books ---");
            foreach (var entry in books)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value.Count} contact(s)");
            }
        }
    }
}
