# 📖 Phone Book Console Application

A simple, robust, and interactive C# Console Application for managing personal contacts. Built with a focus on clean code, the Single Responsibility Principle, and data persistence.

## ✨ Features

- **Add Contacts:** Create new contacts with a name and phone number. Auto-generates a unique ID for each contact.
- **View All Contacts:** Displays a clean list of all saved contacts. Includes validation to alert the user if the phone book is empty.
- **Search Contacts:** Search for a specific contact by name. The search is smart—it ignores extra spaces and is not case-sensitive.
- **Delete Contacts:** Flexible deletion options. Remove a contact by typing their exact Name, or by their unique ID.
- **Data Persistence:** Contacts are never lost. The app automatically loads data from `Contacts.txt` on startup and saves any changes immediately after adding or deleting a contact.
- **Interactive Menu:** Clean, easy-to-navigate console UI with pause states (`Press any key to continue...`) to improve readability.

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET (Console Application)
- **Storage:** Local text file (`Contacts.txt`)

## 📂 Project Structure

The project is separated into distinct classes to maintain clean architecture:

* `Program.cs`: The entry point. Handles the main loop, menu rendering, and application flow.
* `Contact.cs`: The core data model and logic. Manages the static list of contacts, search algorithms, and File I/O operations (Load/Save).
* `PhoneBookManager.cs`: A static helper class dedicated to handling console prompts and capturing user input.
* `Menu.cs`: Handles the rendering of the interactive menu options.

## 🚀 How to Run

1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
2. Clone this repository or download the source code.
3. Open your terminal or command prompt and navigate to the project folder.
4. Run the following command:
   ```bash
   dotnet run"# PhoneBook-CSharp" 
