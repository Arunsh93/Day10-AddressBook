using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC3_EditExistingContact
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
                    Console.WriteLine("=======================================");
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }

        public static void EditContactDetails()
        {
            int i;
            if(contacts.Count>0)
            {
                Console.Write("Enter Person Name you want to Edit: ");
                string editName = Console.ReadLine();

                foreach(var per in contacts)
                {
                    if(editName.ToLower() == per.firstName.ToLower())
                    {
                        while(true)
                        {
                            i = 0;
                            Console.WriteLine("1.First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Zip\n7.Phone Number\n8.EmailId\n9.Exit");
                            Console.Write("Enter option you want to Edit: ");
                            int option2 = int.Parse(Console.ReadLine());
                            switch (option2)
                            {
                                case 1:
                                    Console.Write("Edit First Name: ");
                                    per.firstName = Console.ReadLine();
                                    break;

                                case 2:
                                    Console.Write("Edit Last Name: ");
                                    per.lastName = Console.ReadLine();
                                    break;

                                case 3:
                                    Console.Write("Edit Address: ");
                                    per.address = Console.ReadLine();
                                    break;

                                case 4:
                                    Console.Write("Edit City Name: ");
                                    per.city = Console.ReadLine();
                                    break;

                                case 5:
                                    Console.Write("Edit State Name: ");
                                    per.state = Console.ReadLine();
                                    break;

                                case 6:
                                    Console.Write("Edit Zip Code: ");
                                    per.zip = Console.ReadLine();
                                    break;

                                case 7:
                                    while (true)
                                    {
                                        Console.Write("Edit Phone Number: ");
                                        string phoneNumber = Console.ReadLine();
                                        if (phoneNumber.Length == 10)
                                        {
                                            per.phoneNumber = phoneNumber;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Phone Number");
                                        }
                                    }
                                    break;

                                case 8:
                                    while (true)
                                    {
                                        Console.Write("Edit Email: ");
                                        string emailId = Console.ReadLine();
                                        if (emailId.Contains("@"))
                                        {
                                            per.email = emailId;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid EmailId");
                                        }
                                    }
                                    break;

                                case 9:
                                    Console.WriteLine("Exit From the Contact Edit!");
                                    break;
                            }
                            if (i == 1)
                            {
                                break;
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Entered Name is not in the Contact List");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry! Your Contact List is Empty");
            }
        }
    }
}
