using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class BankCharges
    {

        private double accBalance;
        private int check;

        public BankCharges(double accBalance, int check) 
        {
            this.accBalance = accBalance;
            this.check = check;
        }

        public double getAccBalance()
        {
            return accBalance;
        }
        public int getCheck()
        {
            return check;
        }

        public double calculateFees()
        {
            double fees = 10.0;
            if (check < 20)
            {
               fees = fees + (0.10*check) ;
            }

            if ( (check >= 20 ) && (check <= 39))
            {
                fees += (0.08 * check);
            }

            if ((check >= 40 ) && ( check <= 59))
            {
                fees += (0.06 * check);
            }

            if (check >= 60)
            {
                fees += (0.10 * check);
            }

            if (accBalance < 400)
            {
                fees += 15;
            }

            return fees;
        }

        public double calculateAccBalance()
        {
            accBalance = accBalance - calculateFees();
            
            //return (accBalance-CalculateFees() );
            return accBalance;
        }

        public override string ToString()
        {
            return ("The ending balance is " + calculateAccBalance() + "\n" +
                "The number of check is " + check + "\n" + "The back fees services is " + calculateFees());
        }

        

    }
}
