using System;
using System.Collections.Generic;

namespace AddressBookApp.UseCases
{
    public class MultipleAddressBooks
    {
        private Dictionary<string, List<Dictionary<string, string>>> addressBooks = new();

        public void Execute()
        {
            while (true)
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine();

                var adder = new AddMultipleContacts();
                addressBooks[bookName] = adder.Execute();

                Console.Write("Add another Address Book? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine("\n=== Address Books Summary ===");
            foreach (var (name, list) in addressBooks)
            {
                Console.WriteLine($"Book: {name} — {list.Count} contacts");
            }
        }
    }
}
