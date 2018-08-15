using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class CreditCard
    {
        private int years;
        private double princ_amt, rate;
        private double interest = 0;

        public double Interest { get => interest; }

        public CreditCard(double LoanAmt, double Rate, int NumberOfYears)
        {
            princ_amt = LoanAmt;
            rate = Rate;
            years = NumberOfYears;
            /* Calculate total amount */
            interest = CalculateTotalInterest();
        }


        public double CalculateTotalInterest()
        {
            interest = princ_amt * years * rate / 100;
            return interest;
        }
    }
}
