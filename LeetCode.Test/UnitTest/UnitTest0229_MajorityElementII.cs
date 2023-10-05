using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.UnitTest;


[TestClass]
public class UnitTest0229_MajorityElementII
{
    [TestMethod]
    public void UnitTest0229_MajorityElement(){
        var input = new int[] { 3, 2, 3 };
        var output = new int[] { 3 };
        var actual = MajorityElementII.MajorityElement(input).ToList();
        CollectionAssert.AreEqual(output, actual);
        input = new int[] { 1 };
        output = new int[] { 1 };
        actual = LeetCode.Algorithms.MajorityElementII.MajorityElement(input).ToList();
        CollectionAssert.AreEqual(output, actual);
        input = new int[] { 1, 2 };
        output = new int[] { 1, 2 };
        actual = LeetCode.Algorithms.MajorityElementII.MajorityElement(input).ToList();
        CollectionAssert.AreEqual(output, actual);
        
        
        
    }
}
