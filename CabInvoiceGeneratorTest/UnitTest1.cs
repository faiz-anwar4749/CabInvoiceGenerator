using NUnit.Framework;
using CabInvoiceGenerator_TDD;
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
            double distance = 10;
            int time = 50;
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 150;
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
    }
}