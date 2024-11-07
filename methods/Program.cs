class Program
{

    static void Main(string[] args)
    {

        /* Method = performs a section of code, whenever it's called "invoked".
        Benefit =  Let's us reuse code w/o writing it multiple times */

        // Return  = return data back to the place where a method is invoked

        string name = "Alex";
        int age = 22;
        SingHappyBirthday(name, age);
        Console.ReadKey();
    }

    static void SingHappyBirthday(string name, int age)
    {
        Console.WriteLine("Happy birthday to you ");
        Console.WriteLine("Happy birthday to you ");
        Console.WriteLine("Happy birthday to you ");
        Console.WriteLine("Happy birthday to you " + age);
        Console.WriteLine("You are " + age + " Years old");

    }
}
