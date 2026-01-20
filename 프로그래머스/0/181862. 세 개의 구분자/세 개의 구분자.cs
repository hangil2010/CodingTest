using System;
using System.Linq;
public class Solution {
    public string[] solution(string myStr) {
        string[] answer = new string[] {};
        char[] divChars = new char[3]{'a','b','c'};
        string[] filtered = myStr.Split(divChars).Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
        
        if(filtered.Length == 0)
        {
            answer = new string[1]{"EMPTY"};
        }
        else
        {
            answer = filtered;
        }
        
        return answer;
    }
}