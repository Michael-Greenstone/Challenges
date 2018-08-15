using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoanCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /* Test Case 1: 1 person has 1 wallet and 3 cards (1 Visa, 1 MC 1 Discover) – 
             * Each Card has a balance of $100 – calculate the total interest (simple interest) 
             * for this person and per card. */

            Person MichaelG = new Person("Michael", "Greenstone");
            Wallet firstWallet = new Wallet(100.00, 1, 1, 1, 1);
            MichaelG.AddWallet(firstWallet);
            MichaelG.getTotalsForPerson();
            Assert.AreEqual(16, MichaelG.TotalIntPerPerson);
            Assert.AreEqual(10, MichaelG.TotalVisaIntPerPerson);
            Assert.AreEqual(5, MichaelG.TotalMasterCardIntPerPerson);
            Assert.AreEqual(1, MichaelG.TotalDiscoveryIntPerPerson);

            Console.WriteLine("Total Interest for {0} {1} is: {2}", MichaelG.FistName, MichaelG.LastName, MichaelG.TotalIntPerPerson);
            Console.WriteLine("Total Visa Interest for {0} {1} is: {2}", MichaelG.FistName, MichaelG.LastName, MichaelG.TotalVisaIntPerPerson);
            Console.WriteLine("Total Master Card Interest for {0} {1} is: {2}", MichaelG.FistName, MichaelG.LastName, MichaelG.TotalMasterCardIntPerPerson);
            Console.WriteLine("Total Discovery Interest for {0} {1} is: {2}", MichaelG.FistName, MichaelG.LastName, MichaelG.TotalDiscoveryIntPerPerson);
        }
    }
}
