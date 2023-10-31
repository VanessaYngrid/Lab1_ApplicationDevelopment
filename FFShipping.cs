using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class FFShipping
    {

        private int weight;
        private int miles;

        public FFShipping(int weight, int miles)
        {
            this.weight = weight;
            this.miles = miles;
        }

        public int getWeight(int weight) 
        { 
            return weight;
        }

        public int getMiles() 
        {  
            return miles; 
        }

        public double CalculateRate()
        {
            double rate = 0.0;

            if (weight <= 2)
            {
                rate = 1.10;
            }

            if ((weight > 2) && (weight <= 6))
            {
                rate = 2.20;
            }

            if ((weight > 6) && (weight <=10))
            {
                rate = 3.70;
            }

            if (weight > 10)
            {
                rate = 4.80;
            }

            return rate;
        }

        public int calculateDistance()
        {
            int factor=1;

            if (miles>500) 
            { 
                factor=(miles/500)+1;
            }

            return factor;
        }

        public double shippingCharges()
        {
            return CalculateRate() * calculateDistance();
        }

        public override string ToString()
        {
            return "The final shipping charges is: " + shippingCharges();
        }



    }
}
