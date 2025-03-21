using System;

public class Solution {
    public string solution(string cipher, int code) {
        char[] chars = cipher.ToCharArray();
        string answer = "";
        for(int i = code ; i <= cipher.Length ; i+= code)
        {
            answer += cipher[i-1].ToString();
        }
        return answer;
    }
}