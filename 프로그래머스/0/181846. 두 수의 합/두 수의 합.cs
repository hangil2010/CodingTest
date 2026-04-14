using System;
using System.Text;

public class Solution {
    public string solution(string a, string b) {
        StringBuilder sb = new StringBuilder();
        
        int longText = (int)MathF.Max(a.Length, b.Length);
        int carry = 0;
        
        for (int i = 0; i < longText; i++)
        {
            int aInt = i < a.Length ? a[a.Length - 1 - i] - '0' : 0;
            int bInt = i < b.Length ? b[b.Length - 1 - i] - '0' : 0;

            int sum = carry + aInt + bInt;
            int addChar = sum % 10;
            sb.Insert(0, addChar);

            carry = sum / 10;
        }

        if(carry > 0)
            sb.Insert(0, carry);

        return sb.ToString();
    }
}