using System;
using System.Collections.Generic;


namespace Practica_B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            string userInput;
            do
            {
                Console.Write("Введите имя: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "")
                {
                    Console.Write("Введите номер телефона: ");
                    string phoneNumber = Console.ReadLine();

                    // Добавляем новый контакт
                    contacts.Add(new Contact(userInput, phoneNumber));
                    Console.WriteLine("Контакт добавлен.\n");

                    // Вывод списка контактов для проверки
                    DisplayContacts(contacts);
                }

            } while (userInput.ToLower() != "");

            // Выводим финальный список контактов при выходе
            Console.WriteLine("\nФинальный список контактов:");
            DisplayContacts(contacts);
        }

        // Метод для вывода списка контактов
        static void DisplayContacts(List<Contact> contacts)
        {
            Console.WriteLine("Текущий список контактов:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Имя: {contact.Name}, Телефон: {contact.PhoneNumber}");
            }
            Console.WriteLine(); // Для добавления пустой строки после списка
        }
    }

    // Класс для представления контакта
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}

