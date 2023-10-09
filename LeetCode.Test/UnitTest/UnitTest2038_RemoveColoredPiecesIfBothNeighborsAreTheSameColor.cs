using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest;

[TestClass]
public class UnitTest2038_RemoveColoredPiecesIfBothNeighborsAreTheSameColor
{
    [TestMethod]
    public void UnitTest2038_WinnerOfGame()
    {
        string colors = "AAABABB";
        bool expected = true;
        bool actual = LeetCode.Algorithms._2001_2100.RemoveColoredPiecesIfBothNeighborsAreTheSameColor.WinnerOfGame(colors);
        Assert.AreEqual(expected, actual);
    }
}
