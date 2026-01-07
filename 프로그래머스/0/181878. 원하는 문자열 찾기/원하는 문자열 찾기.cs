using System;

public class Solution {
    public int solution(string myString, string pat) 
    {
        int answer = 0;
        myString = myString.ToLower();
        pat = pat.ToLower();
        
        if(myString.Length < pat.Length)
        {
            answer = 0;
        }
        if(myString.Contains(pat))
        {
            answer = 1;
        }
        
        return answer;
    }
}
