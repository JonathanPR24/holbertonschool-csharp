using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = 75.53;
        int currency = 9876543;

        Console.WriteLine("Percent: {0:F2}% tip", percent);
        Console.WriteLine("Currency: ${0:N2}", currency / 100.0);
    }
}
