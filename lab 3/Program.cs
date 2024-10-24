class Payroll
{
    // Method to calculate tax based on income brackets (Return Method)
    static double CalculateTax(double income)
    {
        if (income <= 1000)
        {
            return income * 0.10; // 10% tax
        }
        else if (income <= 2000)
        {
            return income * 0.15; // 15% tax
        }
        else
        {
            return income * 0.20; // 20% tax
        }
    }

    // Method to calculate gross pay (Return Method)
    static double CalculateGrossPay(double hours, double rate)
    {
        return hours * rate;
    }

    // Method to process payroll (By Reference Method)
    static void ProcessPayroll(List<string> names, List<double> hours, List<double> rates, ref List<double> grossPay, ref List<double> netPay)
    {
        for (int i = 0; i < names.Count; i++)
        {
            // Calculate gross pay
            double gross = CalculateGrossPay(hours[i], rates[i]);
            grossPay.Add(gross);

            // Calculate taxes
            double tax = CalculateTax(gross);

            // Calculate net pay
            double net = gross - tax;
            netPay.Add(net);
        }
    }

    // Void Method to display payroll information
    static void DisplayPayroll(List<string> names, List<double> grossPay, List<double> netPay)
    {
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"Employee: {names[i]}");
            Console.WriteLine($"Gross Pay: ${grossPay[i]:F2}");
            Console.WriteLine($"Net Pay: ${netPay[i]:F2}\n");
        }
    }

    // Method to calculate and return the average net pay (Return Method)
    static double CalculateAverageNetPay(List<double> netPay)
    {
        double total = 0;
        foreach (double net in netPay)
        {
            total += net;
        }
        return total / netPay.Count;
    }

    // Main Method
    static void Main(string[] args)
    {
        // Employee data
        List<string> names = new List<string> { "John Doe", "Jane Smith", "Alice Johnson", "Bob Brown" };
        List<double> hoursWorked = new List<double> { 40, 35, 45, 50 }; // Hours worked by each employee
        List<double> hourlyRates = new List<double> { 25, 30, 20, 22 };  // Hourly rate for each employee

        // Lists to store payroll data (passed by reference)
        List<double> grossPay = new List<double>();
        List<double> netPay = new List<double>();

        // Process payroll (By Ref)
        ProcessPayroll(names, hoursWorked, hourlyRates, ref grossPay, ref netPay);

        // Display payroll (Void)
        DisplayPayroll(names, grossPay, netPay);

        // Calculate and display average net pay (Return)
        double averageNetPay = CalculateAverageNetPay(netPay);
        Console.WriteLine($"Average Net Pay: ${averageNetPay:F2}");
    }
}