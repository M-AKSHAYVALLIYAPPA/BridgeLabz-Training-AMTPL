using System;

namespace AddressBookApp.UseCases
{
    public class AddNewContact
    {
        public void Execute()
        {
            Console.WriteLine("=== Add New Contact ===");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"\nContact Added: {firstName} {lastName}, {address}, {city}, {state}, {zip}, {phone}, {email}");
        }
    }
}
