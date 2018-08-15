using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    public class Wallet
    {

        private double totalPerVisaCard = 0;
        private double totalPerMasterCard = 0;
        private double totalPerDiscoverCard = 0;
        private double totalPerWallet = 0;

        /* Per challenge we assumed that loan amount and loan period are the same for every type of card. Otherwise
         * we would need a separate variables for each type of card. Or separate derrived classes for each card  */
        public Wallet(double LoanAmt, int NumberOfYears, int NumberOfVisas, int NumberOfMCs, int NumberOfDiscovers)
        {
            if (NumberOfVisas > 0)
            {
                CreditCard VisaCC = new CreditCard(LoanAmt, (double)Rates.Visa, NumberOfYears);
                totalPerVisaCard = VisaCC.Interest * NumberOfVisas;
            }

            if (NumberOfMCs > 0)
            {
                CreditCard MasterCardCC = new CreditCard(LoanAmt, (double)Rates.MasterCard, NumberOfYears);
                totalPerMasterCard = MasterCardCC.Interest * NumberOfMCs;
            }

            if (NumberOfDiscovers > 0)
            {
                CreditCard DiscoverCC = new CreditCard(LoanAmt, (double)Rates.Discover, NumberOfYears);
                totalPerDiscoverCard = DiscoverCC.Interest * NumberOfDiscovers;
            }

            /*Total per Wallet */
            totalPerWallet = totalPerVisaCard + totalPerMasterCard + totalPerDiscoverCard;
        }

        public double TotalPerWallet { get => totalPerWallet; }
        public double TotalPerVisaCard { get => totalPerVisaCard; }
        public double TotalPerMasterCard { get => totalPerMasterCard; }
        public double TotalPerDiscoverCard { get => totalPerDiscoverCard; }


    }

    enum Rates
    {
        Visa = 10,
        MasterCard = 5,
        Discover = 1
    }
}
