using System;

public class Solution {
    public int solution(string s) {
        string[] subString = s.Split(" ");
        int answer = 0;
        for(int i = 0 ; i < subString.Length ; i++ ){
            if(subString[i] != "Z") 
            {
                answer += int.Parse(subString[i]);
            }
            else if(subString[i] == "Z")
            {
                answer -= int.Parse(subString[i-1]);
            }
        }
        return answer;
    }
}