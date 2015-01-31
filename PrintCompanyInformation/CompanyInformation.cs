/*
 * Problem 2. Print Company Information
 * A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Company Information:");
        Console.Write("Name: \t\t");
        string companyName = Console.ReadLine();
        Console.Write("Address: \t");
        string companyAddress = Console.ReadLine();

        //Remove white spaces and "+" sign
        Console.Write("Phone number: \t");
        string companyPhone = Console.ReadLine();
        companyPhone = companyPhone.Replace("+", "");
        companyPhone = companyPhone.Replace(" ", "");
        long companyNumber;
        bool parsePhone = Int64.TryParse(companyPhone, out companyNumber);

        //Remove white spaces and "+" sign
        Console.Write("Fax number: \t");
        string companyFax = Console.ReadLine();
        companyFax = companyFax.Replace("+", "");
        companyFax = companyFax.Replace(" ", "");
        long faxNumber;
        bool parseFax = Int64.TryParse(companyFax, out faxNumber);
        
        Console.Write("Web site: \t");
        string companySite = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Manager: ");
        Console.Write("First Name: \t");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last Name: \t");
        string managerLastName = Console.ReadLine();
        Console.Write("Age: \t\t");
        string managerAge = Console.ReadLine();
        //Remove white spaces and "+" sign
        Console.Write("Phone number: \t");
        string managerPhone = Console.ReadLine();
        managerPhone = managerPhone.Replace("+", "");
        managerPhone = managerPhone.Replace(" ", "");
        long managerNumber;
        bool parseManagerPhone = Int64.TryParse(managerPhone, out managerNumber);

        Console.WriteLine();
        Console.WriteLine("Company Information:");
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine(parsePhone ? "Tel. {0:(###)###-###-###}" : "(no phone)", companyNumber);
        Console.WriteLine(parseFax ? "Fax: {0:###-##-##}" : "(no fax)", faxNumber);
        Console.Write("Web site: {0}{1}", companySite, Environment.NewLine);
        Console.Write("Manager: {0} {1} (age: {2}, ", managerFirstName, managerLastName, managerAge );
        Console.WriteLine(parseManagerPhone ? "tel. {0:(###)###-###-###})" : "(no phone)", managerNumber);
    }
}