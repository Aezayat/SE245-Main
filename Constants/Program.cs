namespace Program
{

    class Program
    {

        static void Main(string[] args)
        {
            /* type casting = Converting a value to a different data type
            Useful when we accept user input(string)
            Different data types can do different things */

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c); 

            int e = 321;
            string f = Convert.ToString(e); // What's in Paranthesis is what's being converted 


            // Built in method toGetType() Get's data type of a variable being used
            Console.WriteLine(a.GetType()); // Double
            Console.WriteLine(b.GetType()); // Int32
            Console.WriteLine(d.GetType()); // Double
            Console.WriteLine(f.GetType()); /* Converts e = 321 , to a string. Note - 
            You will not longer be able to use number in a mathmatetical equation */ 
            
            // String to Char
            string g = "$"; 
            char h =  Convert.ToChar(g);
            Console.WriteLine(h.GetType()); //Converts String "$" to a char '$'

            // String to Boolean 
            string i = "true";
            bool j = Convert.ToBoolean(i); 
            Console.WriteLine(j.GetType()); 

            


        }
    }
} 