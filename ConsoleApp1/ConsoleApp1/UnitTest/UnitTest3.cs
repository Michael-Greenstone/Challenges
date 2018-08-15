using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoanCalculator
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            /* Test Case 3: 2 people have 1 wallet each,  person 1 has 1 wallet , with 2 cards MC and visa 
            * person 2 has 1 wallet – 1 visa and 1 MC -  each card has $100 balance - 
            * calculate the total interest(simple interest) for each person and interest per wallet */

            Person JimS = new Person("Jim", "Smith");
            Wallet JimsWallet = new Wallet(100.00, 1, 1, 1, 0);
            JimS.AddWallet(JimsWallet);
            JimS.getTotalsForPerson();
            Assert.AreEqual(15, JimS.TotalIntPerPerson);
            Assert.AreEqual(15, JimS.Wallets[0].TotalPerWallet);
            Console.WriteLine("Total Interest for {0} {1} is: {2}", JimS.FistName, JimS.LastName, JimS.TotalIntPerPerson);
            Console.WriteLine("Total Interest per wallet is: {0}", JimS.Wallets[0].TotalPerWallet);

            Person AnnaS = new Person("Anna", "Smith");
            Wallet AnnasWallet = new Wallet(100.00, 1, 1, 1, 0);
            AnnaS.AddWallet(AnnasWallet);
            AnnaS.getTotalsForPerson();
            Assert.AreEqual(15, AnnaS.TotalIntPerPerson);
            Assert.AreEqual(15, AnnaS.Wallets[0].TotalPerWallet);
            Console.WriteLine("Total Interest for {0} {1} is: {2}", AnnaS.FistName, AnnaS.LastName, AnnaS.TotalIntPerPerson);
            Console.WriteLine("Total Interest per wallet is: {0}", AnnaS.Wallets[0].TotalPerWallet);
        }
    }
}
