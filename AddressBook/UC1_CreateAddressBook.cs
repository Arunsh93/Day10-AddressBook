using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC1_CreateAddressBook
    {
        private static List<PersonDetails> contacts = new List<PersonDetails>();
        public static void AddNewContact()
        {
            PersonDetails person = new PersonDetails();
            Console.Write("Enter First Name: ");
            person.firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.city = Console.ReadLine();

            Console.Write("Enter State: ");
            person.state = Console.ReadLine();

            Console.Write("Enter Zip: ");
            person.zip = Console.ReadLine();

            while(true)
            {
                Console.Write("Enter Phone Number: ");
                string phoneNumber = Console.ReadLine();
                if(phoneNumber.Length == 10)
                {
                    person.phoneNumber = phoneNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Phone Number");
                }
            }

            while (true)
            {
                Console.Write("Enter Email: ");
                string emailId = Console.ReadLine();
                if(emailId.Contains("@"))
                {
                    person.email = emailId;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid EmailId");
                }
            }
            contacts.Add(person);
            Console.WriteLine("Contact Details Added Successfully");
        }

        public static void PrintContactDetails(PersonDetails per)
        {
            Console.WriteLine($"First Name: {per.firstName}");
            Console.WriteLine($"Last Name:  {per.lastName}");
            Console.WriteLine($"Address :   {per.address}");
            Console.WriteLine($"City:       {per.city}");
            Console.WriteLine($"State:      {per.state}");
            Console.WriteLine($"Zip:        {per.zip}");
            Console.WriteLine($"Phone Number: {per.phoneNumber}");
            Console.WriteLine($"EmailId:    {per.email}");
        }
        public static void ShowContacts()
        {
            Console.WriteLine("==================Contacts===================");
            if(contacts.Count > 0)
            {
                foreach(var personDetail in contacts)
                {
                    PrintContactDetails(personDetail);   
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }
    }
}
