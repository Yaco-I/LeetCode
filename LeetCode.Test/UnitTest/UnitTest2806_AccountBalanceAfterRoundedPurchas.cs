using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest
{
    [TestClass]
    public class UnitTest2806_AccountBalanceAfterRoundedPurchas
    {
        [TestMethod]
        public void TestMethodAccountBalanceAfterPurchase()
        {
            int purchaseAmount = 4;
            int result = AccountBalanceAfterRoundedPurchas.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(100, result);

             purchaseAmount = 11;
            result = AccountBalanceAfterRoundedPurchas.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(90, result);


            purchaseAmount = 15;
            result = AccountBalanceAfterRoundedPurchas.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(80, result);
            purchaseAmount = 5;
            result = AccountBalanceAfterRoundedPurchas.AccountBalanceAfterPurchase(purchaseAmount);
            Assert.AreEqual(90, result);
        }
    }
}
