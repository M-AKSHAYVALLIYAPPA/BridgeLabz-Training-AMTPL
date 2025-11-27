using System;

namespace Address_Book_Problem
{
    public class AddNewContact
    {
        public void Execute()
        {
            Console.WriteLine("---- Create a Contact ----");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Street Address: ");
            string address = Console.ReadLine();

            Console.Write("City Name: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip Code: ");
            string zip = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Email ID: ");
            string email = Console.ReadLine();

            string summary = $"{firstName} {lastName} | {address}, {city}, {state} - {zip} | {phone} | {email}";

            Console.WriteLine("\nNew contact saved:");
            Console.WriteLine(summary);
        }
    }
}
