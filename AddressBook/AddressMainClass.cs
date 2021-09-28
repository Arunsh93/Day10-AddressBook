using System;

namespace AddressBook
{
    class AddressMainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            while(true)
            {
                Console.WriteLine("1. Add New Member to Contact List \n2. View Contact List \n3. Exit");
                Console.Write("Enter an Option you Want : ");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        UC1_CreateAddressBook.AddNewContact();
                        break;

                    case 2:
                        UC1_CreateAddressBook.ShowContacts();
                        break;

                    case 3:
                        Console.WriteLine("Exited from Address Book");
                        return;
                }
            }
        }
    }
}
