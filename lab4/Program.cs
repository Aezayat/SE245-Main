//Alex Zayat 10/31/24
//Program Prompt: Create classes and store values to them. Output results
//Variable Dictionary:
/* 
FrstName
middleName
LastName
street1
street2
city
state
zip
phone
email */


using System;

public class Person
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string street1;
    private string street2;
    private string city;
    private string state;
    private string zip;
    private string phone;
    private string email;

    // getters and setters
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string MiddleName
    {
        get { return middleName; }
        set { middleName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Street1
    {
        get { return street1; }
        set { street1 = value; }
    }

    public string Street2
    {
        get { return street2; }
        set { street2 = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public string Zip
    {
        get { return zip; }
        set { zip = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    // Function to display inputs
    public void Display()
    {
        Console.WriteLine($"Name: {FirstName} {MiddleName} {LastName}");
        Console.WriteLine($"Address: {Street1}, {Street2}, {City}, {State}, {Zip}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person
        {
            FirstName = "Edmond",
            MiddleName = "A.",
            LastName = "Stark",
            Street1 = "48 Washington Street",
            Street2 = "Apt 12",
            City = "Providence",
            State = "RI",
            Zip = "02911",
            Phone = "555-1234",
            Email = "AStark@yahoo.com"
        };

        person.FirstName = "Poopy " + person.FirstName;

        person.Display();
    }
}