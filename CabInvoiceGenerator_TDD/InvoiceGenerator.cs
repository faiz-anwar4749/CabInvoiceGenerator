using System;
using System.Collections.Generic;
using System.Text;
namespace CabInvoiceGenerator_TDD
{
    public class InvoiceGenerator
    {
        private readonly double MINIMUM_COST_PER_KM = 10;
        private readonly int COST_PER_MINUTE = 1;
        private readonly double MINIMUM_FARE = 5;
        public double CalculateFare(double distance, int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_MINUTE;
            }
            catch (CabInvoiceException)
            {
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid distance");
                }
                if (time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid time");

                }
            }
            totalFare = Math.Max(totalFare, MINIMUM_FARE);
            Console.WriteLine("The total fare is: " + totalFare);
            return totalFare;
        }
        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                foreach (Ride ride in rides)
                {
                    totalFare += this.CalculateFare(ride.distance, ride.time);
                }
            }
            catch (CabInvoiceException)
            {
                if (rides == null)
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "rides are null");
            }
            return new InvoiceSummary(rides.Length, totalFare);
        }
    }    
}
