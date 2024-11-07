using System;

namespace MyFirstProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man a plan a canal panama "));



        }

        static bool IsPalindrome(string word)
        {
            //Your implementation here
            for(int i = 0; i < (word.Length / 2); i++ );
                char leftChar = word[i];
                char rightChar = word[word.Length - (1 + 1)];
                Console.WriteLine($"LeftChar: {leftChar} RightChar; {rightChar}");

            return true ;

            
        }
    }

}