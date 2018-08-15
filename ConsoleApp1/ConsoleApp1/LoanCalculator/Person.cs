using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    public class Person
    {
        private string fistName;
        private string lastName;
        private double totalIntPerPerson = 0;
        private double totalVisaIntPerPerson = 0;
        private double totalMasterCardIntPerPerson = 0;
        private double totalDiscoveryIntPerPerson = 0;


        private List<Wallet> wallets;

        public string FistName { get => fistName; set => fistName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double TotalIntPerPerson { get => totalIntPerPerson; }
        public int NumberOfWallets { get => Wallets.Count; }
        public double TotalVisaIntPerPerson { get => totalVisaIntPerPerson; }
        public double TotalMasterCardIntPerPerson { get => totalMasterCardIntPerPerson; }
        public double TotalDiscoveryIntPerPerson { get => totalDiscoveryIntPerPerson; }

        public List<Wallet> Wallets { get => wallets; }

        public Person(string Firstname, string Lastname)
        {
            fistName = Firstname;
            lastName = Lastname;
            /* Initialize wallets list */
            wallets = new List<Wallet>();

        }

        public void AddWallet(Wallet wallet)
        {
            Wallets.Add(wallet);
        }

        public void getTotalsForPerson()
        {
            foreach (Wallet currWallet in Wallets)
            {
                totalIntPerPerson += currWallet.TotalPerWallet;
                totalVisaIntPerPerson += currWallet.TotalPerVisaCard;
                totalMasterCardIntPerPerson += currWallet.TotalPerMasterCard;
                totalDiscoveryIntPerPerson += currWallet.TotalPerDiscoverCard;
            }
        }
    }
}
