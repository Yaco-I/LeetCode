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
        }
    }
}
