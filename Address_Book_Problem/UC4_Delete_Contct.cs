using System;
using System.Collections.Generic;

namespace Address_Book_Problem
{
    public class DeleteContact
    {
        public void Execute(List<Dictionary<string, string>> contacts)
        {
            Console.Write("Enter the first name of the contact you want to remove: ");
            string searchName = Console.ReadLine();

            var contact = contacts.Find(c =>
                c.ContainsKey("FirstName") &&
                c["FirstName"].Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("No contact found with that name.");
                return;
            }

            contacts.Remove(contact);
            Console.WriteLine("\nThe contact has been deleted.");
        }
    }
}
