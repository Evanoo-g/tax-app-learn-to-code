using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class TaxCalc
    {

        public decimal Calc(decimal input)
        {

            if (input <= 12500)
            {
                return 0;
            }

            decimal moneyWeCanTaxAt40pc = 0;
            decimal moneyWeCanTaxAt20pc = 0;


            moneyWeCanTaxAt40pc = input - 50_000;
            if (moneyWeCanTaxAt40pc < 0)
            {
                moneyWeCanTaxAt40pc = 0;
            }

            if (input > 50_000)
            { moneyWeCanTaxAt20pc = 37_500; }

            if (input <= 50_000)
            {
                moneyWeCanTaxAt20pc = input - 12_500;
            }

            return (moneyWeCanTaxAt20pc * 0.2M) + (moneyWeCanTaxAt40pc * .4M);


        }
    }
}
