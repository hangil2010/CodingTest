using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;
        
        bool isContain = my_string.EndsWith(is_suffix);
        if(isContain)
        {
            answer = 1;
        }
        
        return answer;
    }
}