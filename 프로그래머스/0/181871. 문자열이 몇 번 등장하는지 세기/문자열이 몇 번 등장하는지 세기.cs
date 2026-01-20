using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        for(int i = 0 ; i < myString.Length - pat.Length + 1; i++)
        {
            if(myString.Substring(i, pat.Length).Equals(pat))
            {
                answer++;
            }
        }
        
        return answer;
    }
}