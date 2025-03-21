using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string) {
        List<int> number = new List<int>();
        char[] chars = my_string.ToCharArray();
        Array.Sort(chars);
        for(int i = 0 ; i < my_string.Length ; i++)
        {
            if(chars[i] > 57) { break;}
            else
            {
                number.Add((int)Char.GetNumericValue(chars[i]));    
            }
        }
        int answer = 0;
        foreach(int num in number)
        {
            answer += num;
        }
        return answer;
    }
}