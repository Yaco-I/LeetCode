using LeetCode.Algorithms.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public class UnitTest36_ValidSodoku
    {
        [TestMethod]
        public void MethodTest_IsValidSodoku()
        {
            char[][] sodoku1 = new char[][] {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}};


            char[][] sodoku2= new char[][] {
            new char[] {'.','.','.','9','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','3','.','.','.','.','.','1'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'1','.','.','.','.','.','3','.','.'},
            new char[] {'.','.','.','.','2','.','6','.','.'},
            new char[] {'.','9','.','.','.','.','.','7','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'8','.','.','8','.','.','.','.','.'}};

            char[][] sodoku3 = new char[][] {
            new char[] {'.','.','.','.','5','.','.','1','.'},
            new char[] {'.','4','.','3','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','3','.','.','1'},
            new char[] {'8','.','.','.','.','.','.','2','.'},
            new char[] {'.','.','2','.','7','.','.','.','.'},
            new char[] {'.','1','5','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','2','.','.','.'},
            new char[] {'.','2','.','9','.','.','.','.','.'},
            new char[] {'.','.','4','.','.','.','.','.','.'}
            };


            var result1 = ValidSodoku.IsValidSudoku(sodoku1);
            var result2 = ValidSodoku.IsValidSudoku(sodoku2);
            var result3 = ValidSodoku.IsValidSudoku(sodoku3);
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);


        }
    }
}
