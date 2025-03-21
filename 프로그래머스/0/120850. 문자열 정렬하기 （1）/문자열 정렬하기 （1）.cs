using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string my_string) {
        // 48 ~ 57
        char[] chars = my_string.ToCharArray();
        Array.Sort(chars);
        List<int> number = new List<int>();
        for(int i = 0 ; i < my_string.Length ; i++){
            if(chars[i] > 57) { break;}
            else
            {
                number.Add((int)Char.GetNumericValue(chars[i]));
            }
        }
        return number.ToArray();
    }
}