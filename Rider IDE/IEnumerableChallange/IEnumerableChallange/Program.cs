using System;
using System.Collections;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public static class Program
    {
        static public void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
    }

    public class Contact
    {
        public string name { get; set; }
        public string number { get; set; }

        public Contact(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        public void Call()
        {
            Console.WriteLine("Calling to {0}. Phone number is {1}", this.name, this.number);
        }
    }

    public class PhoneBook : IEnumerable<Contact>
    {
        List<Contact> Contacts = new List<Contact>{
            new Contact("Andre", "435797087"),
            new Contact("Lisa", "435677087"),
            new Contact("Dine", "3457697087"),
            new Contact("Sofi", "4367697087")
        };

        public IEnumerator<Contact> GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }

        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}