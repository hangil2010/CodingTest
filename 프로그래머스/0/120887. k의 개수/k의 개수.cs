using System;
using System.Linq;
public class Solution {
    public int solution(int i, int j, int k) {
        int[] array = Enumerable.Range(i, j-i+1).ToArray(); 
        int answer = 0;
        for(int n = 0 ; n < array.Length ; n++)
        {
            string str = array[n].ToString();
            for(int m = 0 ; m < str.Length ; m++)
            {
                if(str[m] == (char)(k+ '0'))
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}