using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PhoneBook
{
    public class Contact
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        static List<Contact> contacts = new List<Contact>();
        public Contact(string name, string phoneNumber)
        {
            Id = _nextId++;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public static void AddContact(string name, string phoneNumber)
        {
            Contact newContact = new Contact(name, phoneNumber);
            contacts.Add(newContact);
        }
        public static void DeleteContact(int id)
        {
            for (int i = contacts.Count - 1; i >= 0; i--)
            {
                if (contacts[i].Id == id)
                {
                    contacts.RemoveAt(i);
                    break;
                }
            }
        }
        public static void DeleteContact(string name)
        {
            for (int i = contacts.Count - 1; i >= 0; i--)
            {
                if (contacts[i].Name == name)
                {
                    contacts.RemoveAt(i);
                }
            }
        }
        public static void ListAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("The list of contacts is empty!");
                return;
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"{contact.Id} | {contact.Name}:\n{contact.PhoneNumber}");
                }
            }
            
        }
        public static void SearchContact(string name)
        {
            bool isFound = false;

            foreach (var contact in contacts)
            {
                if (contact.Name.Trim().Contains(name.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{contact.Id} | {contact.Name}:\nNumber: {contact.PhoneNumber}");
                    isFound = true;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"Contact '{name}' not found.");
            }
        }
        public static void LoadContacts()
        {
            string path = @"Contacts.txt";
            if(!File.Exists(path))
            {
                File.CreateText(path).Close();
            }
            else
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    // Evitar líneas vacías que puedan crashear el programa
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Cortar la línea de texto en pedazos usando la coma como separador
                    string[] parts = line.Split(',');

                    // Asegurarnos de que la línea realmente tiene dos partes (Nombre y Teléfono)
                    if (parts.Length == 2)
                    {
                        string name = parts[0].Trim();
                        string phone = parts[1].Trim();

                        // Usar tu método existente para crear el contacto y añadirlo a la lista
                        AddContact(name, phone);
                    }
                }
            }
        }
        public static void SaveContacts()
        {
            string path = @"Contacts.txt";
            List<string> lines = new List<string>();

            foreach (var contact in contacts)
            {
                lines.Add($"{contact.Name},{contact.PhoneNumber}");
            }
            File.WriteAllLines(path, lines);
        }
    }
}
