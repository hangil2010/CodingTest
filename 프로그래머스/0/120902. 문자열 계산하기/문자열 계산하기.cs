using System;

public class Solution {
    public int solution(string my_string) {
        string[] subString = my_string.Split(" ");
        int answer = int.Parse(subString[0]);
        for(int i = 0 ; i < subString.Length ; i++){
            if(subString[i] == "+"){
                answer += int.Parse(subString[i+1]);
            }
            if(subString[i] == "-"){
                answer -= int.Parse(subString[i+1]);
            }
        }
        return answer;
    }
}