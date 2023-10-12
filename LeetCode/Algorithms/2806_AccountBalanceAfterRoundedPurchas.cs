using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    
    public class AccountBalanceAfterRoundedPurchas
    {
        public static int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            //if (purchaseAmount == 0)
            //    return 100;
            string purchaseAmountString = purchaseAmount.ToString();
            int lastDigit = int.Parse(purchaseAmountString[purchaseAmountString.Length - 1].ToString());
            if (lastDigit >= 5)
            {
                purchaseAmount += 10 - lastDigit;
            }
            else{
                purchaseAmount -= lastDigit;
            }

            return 100 - purchaseAmount;

            //decimal purchaseAmountDecimal = (decimal)(purchaseAmount) / 10;
            //purchaseAmountDecimal = Math.Round(purchaseAmountDecimal);
            //return 100 - int.Parse(purchaseAmountDecimal.ToString()) * 10 ;
        }
    }
}
