using System;
using System.Linq;
public class Solution {
    public int[] solution(string my_string) {
        int[] upper = Enumerable.Repeat<int>(0, 26).ToArray<int>();
        int[] lower = Enumerable.Repeat<int>(0, 26).ToArray<int>();
        
        int length = my_string.Length;
        for(int i = 0 ; i < length ; i++)
        {
            if(Char.IsUpper(my_string[i]))
            {
                upper[my_string[i] - 65]++;
            }
            else
            {
                lower[my_string[i] - 97]++;
            }
        }
        
        return upper.Concat(lower).ToArray();
    }
}