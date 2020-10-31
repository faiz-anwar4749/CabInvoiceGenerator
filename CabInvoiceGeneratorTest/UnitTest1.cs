using NUnit.Framework;
using CabInvoiceGenerator_TDD;
using System;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_CalculateFareMethodShould_ReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 20;
            int time = 50;
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 250;
            Assert.AreEqual(expectedFare, actualFare);
        }
        [Test]
        public void GivenDistanceAndTime_CalculateFareMethodShould_ReturnMinimumFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 0.1;
            int time = 3;
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 5;
            Assert.AreEqual(expectedFare, actualFare);
        }
        [Test]
        public void GivenMultipleRideShouldReturnAggregateFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides =
            {
                new Ride(2.0, 5),
                new Ride(0.1, 5),
                new Ride(3.0, 7)
            };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);

            InvoiceSummary expectedSummary = new InvoiceSummary(3, 68.0);
            Assert.AreEqual(summary, expectedSummary);
        }
    }
}