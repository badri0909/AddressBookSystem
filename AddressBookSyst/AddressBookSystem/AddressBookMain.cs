using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        int pinCode;
        long phone_number;
        string email;
        public void AddressBook()
        {
            firstName = "Badri";
            lastName = "Chowdhary";
            address = "6-33,gandhi chowk wyra";
            city = "Khammam";
            state = "Telangana";
            pinCode = 507165;
            phone_number = 9398599965;
            email = "singuveerbhadrarao@gmail.com";

            Console.WriteLine("FirstName: " + firstName + "\nLastName: " + lastName + "\nAdress: " + address + "\nCity: " + city + "\nState: " + state + "\nPinCode: " + pinCode + "\nPhoneNUmber: " + phone_number + "\nEmailId: " + email);
        }
        public void AddressBook(string name, string lastName, string address, string city, string state, int pinCode, long contact, string email)
        {
            firstName = name;
            lastName = lastName;
            address = address;
            city = city;
            state = state;
            pinCode = pinCode;
            phone_number = contact;
            email = email;
            Console.WriteLine("Hi " + firstName + " " + lastName + " your details have been saved");
        }
    }
}