using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        my_string = my_string.ToLower();
        char[] chars = my_string.ToCharArray();
        Array.Sort(chars);
        foreach(char c in chars){
            answer += c.ToString();
        }
        return answer;
    }
}