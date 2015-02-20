using System;
//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Company phone number: ");
            string companyPhoneNumber = Console.ReadLine();
            Console.WriteLine("Company fax number: ");
            string companyFaxNumber = Console.ReadLine();
            Console.WriteLine("Company web site: ");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager Last name: ");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age: ");
            int managerAge =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Manager phone number: ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + companyPhoneNumber);
            Console.WriteLine("Fax: " + companyFaxNumber);
            Console.WriteLine("Web site: " + companyWebSite);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerPhoneNumber + ")");
        }
    }
}
