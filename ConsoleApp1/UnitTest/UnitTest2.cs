using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoanCalculator
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            /* Test Case 2: 1 person has 2 wallets  Wallet 1 has a Visa and Discover , wallet 2 a MC 
            * -  each card has $100 balance - calculate the total interest(simple interest) for 
            * this person and interest per wallet */

            Person JohnD = new Person("John", "Doe");
            Wallet FirstWallet = new Wallet(100.00, 1, 1, 0, 1);
            JohnD.AddWallet(FirstWallet);
            Wallet SecondWallet = new Wallet(100.00, 1, 0, 1, 0);
            JohnD.AddWallet(SecondWallet);
            JohnD.getTotalsForPerson();
            Assert.AreEqual(16, JohnD.TotalIntPerPerson);
            Assert.AreEqual(11, JohnD.Wallets[0].TotalPerWallet);
            Assert.AreEqual(5, JohnD.Wallets[1].TotalPerWallet);
            Console.WriteLine("Total Interest for {0} {1} is: {2}", JohnD.FistName, JohnD.LastName, JohnD.TotalIntPerPerson);
            Console.WriteLine("Total Interest for 1st wallet is: {0}", JohnD.Wallets[0].TotalPerWallet);
            Console.WriteLine("Total Interest for 2nd wallet is {0}", JohnD.Wallets[1].TotalPerWallet);

        }
    }
}
