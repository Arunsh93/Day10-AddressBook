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
                Console.WriteLine("1. Add New Member to Contact List \n2. View Contact List \n3. Edit Contact \n4. Exit");
                Console.Write("Enter an Option you Want : ");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        UC3_EditExistingContact.AddNewContact();
                        break;

                    case 2:
                        UC3_EditExistingContact.ShowContacts();
                        break;

                    case 3:
                        UC3_EditExistingContact.EditContactDetails();
                        break;

                    case 4:
                        Console.WriteLine("Exited from Address Book");
                        return;
                }
            }
        }
    }
}
