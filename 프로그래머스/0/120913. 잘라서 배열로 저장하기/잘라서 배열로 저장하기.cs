using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        int length = 0;
        if(my_str.Length % n == 0)
        { 
            length = my_str.Length/n;
        }
        else
        { 
            length = my_str.Length/n + 1;
        }
        string[] answer = new string[length];
        for(int i = 0 ; i < length ; i++){
            if(my_str.Length < n) 
            { 
                answer[i] = my_str;
            }
            else{
                answer[i] += my_str.Substring(0, n);
                my_str = my_str.Substring(n);
            }
        }
        return answer ;
    }
}