using System;
using System.Collections.Generic;
using System.Text;
namespace CabInvoiceGenerator_TDD
{
    public class InvoiceGenerator
    {
        public double CalculateFare(double distance, int time)
        {
            int costPerKilometer = 10;
            int costPerMinute = 1;
            int minimumFare = 5;
            double totalFare = distance * costPerKilometer + time * costPerMinute;
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            Console.WriteLine("The total fare is: " +totalFare);
            return totalFare;
        }
    }
}
