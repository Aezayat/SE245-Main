﻿class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine(); //Console.ReadLine stores value into variable


        Console.WriteLine("What's your age?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello " + name);
        Console.WriteLine("You are " + age + " years old");

        Console.ReadKey();
    }


        
}