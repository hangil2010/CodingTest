using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        bool isVowel = false;
        char[] vowels = new char[5]{'a','e','i','o','u'};
        foreach(char c in my_string)
        {
            isVowel = false;
            for(int i = 0 ; i < vowels.Length ; i++)
            {
                if(c == vowels[i]) 
                {   
                    isVowel = true;
                    break;
                }
            }
            if(!isVowel)
            {
                answer += c.ToString();
            }
        }
        return answer;
    }
}