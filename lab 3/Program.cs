// Alex Zayat
// 10-24-24
/* 
Program Prompt:
1. Calculates and displays employee pay for a 40-hour work week.
2. Asks users to enter a number of employees, or handle the number of employees dynamically.
3. Input: name, hours worked, hourly rate, along with taxes deducted based on tax bracket and store each in a series of lists.
4. For each employee, loop through the lists, calculate the pay, and display it with the person’s name.
5. Calculate and display the average income. */


class Program
{
    static void Main(string[] args)
    {
        // Declare Variable
        int empCounter; // Employee counter

        // Lists to store employee data
        List<string> names = new List<string>();
        List<double> hoursWorked = new List<double>();
        List<double> hourlyRates = new List<double>();
        List<double> taxDeducted = new List<double>();

        // Function to calculate net pay after taxes
        double CalculateNetPay(double grossPay, double taxAmount)
        {
            return grossPay - taxAmount;
        }

        // Function to determine tax bracket based on gross income
        double DetermineTaxBracket(double grossPay)
        {
            if (grossPay <= 1000)
                return 10;  // 10% tax
            else
                return 20;  // 20% tax
        }

        // Ask for the number of employees
        Console.Write("Enter the number of employees: ");
        empCounter = int.Parse(Console.ReadLine());

        // Input details for each employee
        for (int i = 0; i < empCounter; i++)
        {
            Console.Write($"\nEnter name of employee {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter hours worked by {name}: ");
            double hours = double.Parse(Console.ReadLine());

            Console.Write($"Enter hourly rate for {name}: ");
            double rate = double.Parse(Console.ReadLine());

            // Calculate gross pay and tax bracket
            double grossPay = hours * rate;
            double taxBracket = DetermineTaxBracket(grossPay);
            double taxAmount = grossPay * (taxBracket / 100);

            // Calculate net pay
            double netPay = CalculateNetPay(grossPay, taxAmount);

            // Store data in lists
            names.Add(name);
            hoursWorked.Add(hours);
            hourlyRates.Add(rate);
            taxDeducted.Add(taxAmount);

            // Display individual employee's pay
            Console.WriteLine($"\n{name}'s gross pay is: ${grossPay}");
            Console.WriteLine($"{name}'s net pay is: ${netPay:F2} after {taxBracket}% tax");
        }

        // Calculate and display the average income
        double totalNetPay = 0;
        for (int i = 0; i < empCounter; i++)
        {
            double grossPay = hoursWorked[i] * hourlyRates[i];
            totalNetPay += CalculateNetPay(grossPay, taxDeducted[i]);
        }

        double averageIncome = totalNetPay / empCounter;
        Console.WriteLine($"\nThe average net income of all employees is: ${averageIncome:F2}");
    }
}