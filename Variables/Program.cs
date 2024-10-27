

class Program
{
    static void Main(string[] args)
    {
        // Variables are containers for values
        // Integer 
        // Float, Double, Decimal
        // Boolean
        //Char only 1 value, must be placed in single quotes ' ' 

        int x; //declaration
        x = 123; //initialization

        int y = 321; // declaration + initialization


        int age = 22; // whole integer
        double height = 154; //decimal number
        bool alive = true; //True or False
        char symbol = '@';
        string name = "Me";
        

        Console.WriteLine("Hello " + name);
        Console.WriteLine("Your age is " + age);
        Console.WriteLine("Your height is " + height + "cm");
        Console.WriteLine("Are you alive? " + alive);
        Console.WriteLine("Your syombol is: " + symbol);

        string userName = symbol + name;

        Console.WriteLine("Your username is: " + userName);
    }
}