using System;
using System.Collections.Generic;

namespace AddressBookApp.UseCases
{
    public class EditContact
    {
        public void Execute(List<Dictionary<string, string>> contacts)
        {
            Console.Write("Enter First Name of contact to edit: ");
            string name = Console.ReadLine();

            var contact = contacts.Find(c => c["FirstName"].Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.WriteLine("Enter new details:");
            Console.Write("New Address: ");
            contact["Address"] = Console.ReadLine();
            Console.Write("New City: ");
            contact["City"] = Console.ReadLine();
            Console.Write("New State: ");
            contact["State"] = Console.ReadLine();
            Console.Write("New Zip: ");
            contact["Zip"] = Console.ReadLine();

            Console.WriteLine("\nContact updated successfully!");
        }
    }
}
