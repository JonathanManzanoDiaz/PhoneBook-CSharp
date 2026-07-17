using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{

    class Menu
    {
        private string Prompt;
        private string[] Options;
        private int SelectedIndex;
        
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        public void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Phone Book By Jonathan Manzano Diaz");
            Console.Title = "Phone Book";

            Console.WriteLine(@"
   ___ _                          ___             _    
  / _ \ |__   ___  _ __   ___    / __\ ___   ___ | | __
 / /_)/ '_ \ / _ \| '_ \ / _ \  /__\/// _ \ / _ \| |/ /
/ ___/| | | | (_) | | | |  __/ / \/  \ (_) | (_) |   < 
\/    |_| |_|\___/|_| |_|\___| \_____/\___/ \___/|_|\_\
                                                       
    ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ──────────────────────────────────────────────────────────────────────────────────────────");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n >> {Prompt} << \n");
            Console.ResetColor();
            string prefix = "*";
            for (int i = 0; i < Options.Length; i++)
            {
                if (i == SelectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{prefix} {Options[i]} ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"  {Options[i]} ");

                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if(SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                if(keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if(SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }

    }
}