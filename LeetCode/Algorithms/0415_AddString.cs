using System.Text;

namespace LeetCode.Algorithms;

public class AddString
{

    public static string AddStrings(string num1, string num2)
    {
        int Length1 = num1.Length;
        int Length2 = num2.Length;
        int Length = Math.Max(Length1, Length2);
        int Carry = 0;
        int digit = 0;
        StringBuilder Result = new StringBuilder();
        for (int i = 1; i <= Length; i++)
        {
            digit = 0;
            if (i <= Length1)
            {
                digit += int.Parse(num1[Length1 - i].ToString());
            }
            if (i <= Length2)
            {
                digit += int.Parse(num2[Length2 - i].ToString());

            }
            if (Carry > 0)
            {
                digit += Carry;
                Carry = 0;
            }
            if (digit > 9)
            {
                Carry = 1;
                digit -= 10;
            }
            Result.Insert(0, digit);
        }
        if(Carry > 0)
        {
            Result.Insert(0, Carry);
        }
        return Result.ToString();
    }
}
