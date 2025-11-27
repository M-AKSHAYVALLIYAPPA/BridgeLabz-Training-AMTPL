using System;
using System.Collections.Generic;

namespace Address_Book_Problem
{
    public class EditContact
    {
        public void Execute(List<Dictionary<string, string>> contacts)
        {
            Console.Write("Enter the first name of the contact you want to modify: ");
            string searchName = Console.ReadLine();

            var contact = contacts.Find(c =>
                c.ContainsKey("FirstName") &&
                c["FirstName"].Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("No matching contact found.");
                return;
            }

            Console.WriteLine("\nUpdate Details:");
            Console.Write("Address: ");
            contact["Address"] = Console.ReadLine();

            Console.Write("City: ");
            contact["City"] = Console.ReadLine();

            Console.Write("State: ");
            contact["State"] = Console.ReadLine();

            Console.Write("Zip Code: ");
            contact["Zip"] = Console.ReadLine();

            Console.WriteLine("\nContact information updated.");
        }
    }
}
