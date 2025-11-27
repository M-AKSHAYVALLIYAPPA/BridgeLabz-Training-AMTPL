using System;
using System.Collections.Generic;

namespace AddressBookApp.UseCases
{
    public class DeleteContact
    {
        public void Execute(List<Dictionary<string, string>> contacts)
        {
            Console.Write("Enter First Name of contact to delete: ");
            string name = Console.ReadLine();

            var contact = contacts.Find(c => c["FirstName"].Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            contacts.Remove(contact);
            Console.WriteLine("\nContact deleted successfully!");
        }
    }
}
