using System;

public class Solution {
    public int solution(int order) {
        int len = order.ToString().Length;
        char[] numChar = order.ToString().ToCharArray();
        int answer = 0;
        foreach(char c in numChar)
        {
            if( Char.GetNumericValue(c) == 0) {continue;}
            if( Char.GetNumericValue(c) % 3 == 0) {answer++;}
        }
        return answer;
    }
}