using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(char ch in my_string)
        {
            if(Char.IsLower(ch)) 
            {
                answer += Char.ToUpper(ch).ToString();
            }
            else if(Char.IsUpper(ch))
            {
                answer += Char.ToLower(ch).ToString();
            }
        }
        return answer;
    }
}