using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PhoneBook
{
    class PhoneBookManager
    {
     
        public static string[] AskData()
        {
            Console.WriteLine("What is the name you want to add in the contact?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"What is the phone number you want to add in the {name}?: ");
            string phoneNumber = Console.ReadLine();
            string[] data = { name, phoneNumber };
            return data;
        }
        public static int AskID()
        {
            int contactID;
            Console.WriteLine("What is the id of the contact you want to delete?: ");
            string contact = Console.ReadLine();
            bool success = int.TryParse(contact, out contactID);
            return contactID;
        }
        public static string AskName(string action)
        {
            Console.WriteLine($"What is the name of the contact you want to {action}?: ");
            return Console.ReadLine();
        }
        public static void AskDelete()
        {
            Console.WriteLine($"1.- Delete contacts by ID\n2.- Delete contacts by Name");
            string result = Console.ReadLine();
            if (result.Contains("1"))
            {
                Contact.DeleteContact(AskID());
            } else if (result.Contains("2"))
            {
                Contact.DeleteContact(AskName("delete"));
            }
            else
            {
                Console.WriteLine("Please introduce 1 or 2.");
            }
        }
    }
}

