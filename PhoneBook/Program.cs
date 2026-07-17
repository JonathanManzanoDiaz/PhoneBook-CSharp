namespace PhoneBook {
    class Program {
        public static void WaitForKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }
        static void Main(string[] args) {
            string prompt = "Phone Book by Jonathan Manzano Diaz";
            string[] options = { "Add contact", "Delete contact", "View all contacts", "Search Contact", "Exit"};
            Menu mainMenu = new Menu(prompt, options);
            Contact.LoadContacts();
            bool appRunning = true;
            while (appRunning)
            {
                int SelectedIndex = mainMenu.Run();
                switch (SelectedIndex)
                {
                    case 0:
                        string[] data = PhoneBookManager.AskData();
                        Contact.AddContact(data[0], data[1]);
                        Contact.SaveContacts();
                        Console.WriteLine("Contact added succesfully!");
                        WaitForKey();
                        break;
                    case 1:
                        PhoneBookManager.AskDelete();
                        Contact.SaveContacts();
                        Console.WriteLine("Contact Deleted succesfully!");
                        WaitForKey();
                        break;
                    case 2:
                        Contact.ListAllContacts();
                        WaitForKey();
                        break;
                    case 3:
                        Contact.SearchContact(PhoneBookManager.AskName("search"));
                        WaitForKey();
                        break;
                    case 4:
                        Console.WriteLine("Have a nice day!");
                        Contact.SaveContacts();
                        appRunning = false;
                        break;
                }
            }
        }
    }
}
